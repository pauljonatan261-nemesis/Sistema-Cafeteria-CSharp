using System;
using System.Data;
using System.Data.SqlClient;

namespace FormCRUDB
{
    public class VentaDAL
    {
        // Carga los clientes de la tabla Clientes para el ComboBox
        public static DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT Id_cliente, Nombre + ' ' + Apellido AS NombreCompleto FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Guarda Pedido + Detalle_Pedido + Descuenta Stock + Ejecuta sp_RegistrarPago
        public static int RegistrarVentaCompleta(int idCliente, DataTable detalleCarrito, decimal totalPagado, string metodoPago)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    // 1. Calcular el siguiente Id_pedido (la tabla Pedidos no tiene IDENTITY)
                    int nuevoIdPedido = ObtenerSiguienteId(conn, transaccion, "Pedidos", "Id_pedido");

                    // 2. Insertar encabezado en Pedidos
                    string sqlPedido = @"INSERT INTO Pedidos (Id_pedido, Id_cliente, Fecha_pedido, Estado_pedido)
                                         VALUES (@Id_pedido, @Id_cliente, @Fecha_pedido, 'Pendiente')";
                    using (SqlCommand cmdPedido = new SqlCommand(sqlPedido, conn, transaccion))
                    {
                        cmdPedido.Parameters.AddWithValue("@Id_pedido", nuevoIdPedido);
                        cmdPedido.Parameters.AddWithValue("@Id_cliente", idCliente);
                        cmdPedido.Parameters.AddWithValue("@Fecha_pedido", DateTime.Now.Date);
                        cmdPedido.ExecuteNonQuery();
                    }

                    // 3. Insertar líneas en Detalle_Pedido y descontar stock en Productos
                    int siguienteIdDetalle = ObtenerSiguienteId(conn, transaccion, "Detalle_Pedido", "Id_detalle");

                    foreach (DataRow fila in detalleCarrito.Rows)
                    {
                        int idProducto = Convert.ToInt32(fila["Id"]);
                        int cantidad = Convert.ToInt32(fila["Cantidad"]);
                        decimal precioUnitario = Convert.ToDecimal(fila["Precio"]);

                        string sqlDetalle = @"INSERT INTO Detalle_Pedido (Id_detalle, Id_pedido, Id_producto, Cantidad, Precio_unitario)
                                              VALUES (@Id_detalle, @Id_pedido, @Id_producto, @Cantidad, @Precio_unitario)";
                        using (SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, conn, transaccion))
                        {
                            cmdDetalle.Parameters.AddWithValue("@Id_detalle", siguienteIdDetalle++);
                            cmdDetalle.Parameters.AddWithValue("@Id_pedido", nuevoIdPedido);
                            cmdDetalle.Parameters.AddWithValue("@Id_producto", idProducto);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdDetalle.Parameters.AddWithValue("@Precio_unitario", precioUnitario);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        // Actualizar stock disponible
                        string sqlStock = @"UPDATE Productos 
                                            SET Cantidad = Cantidad - @Cantidad 
                                            WHERE Id = @Id_producto AND Cantidad >= @Cantidad";
                        using (SqlCommand cmdStock = new SqlCommand(sqlStock, conn, transaccion))
                        {
                            cmdStock.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdStock.Parameters.AddWithValue("@Id_producto", idProducto);

                            if (cmdStock.ExecuteNonQuery() == 0)
                                throw new Exception($"Stock insuficiente para el producto: {fila["Producto"]}");
                        }
                    }

                    // 4. Registrar el pago usando el Procedimiento Almacenado sp_RegistrarPago
                    int nuevoIdPago = ObtenerSiguienteId(conn, transaccion, "Pagos", "Id_pago");
                    using (SqlCommand cmdPago = new SqlCommand("sp_RegistrarPago", conn, transaccion))
                    {
                        cmdPago.CommandType = CommandType.StoredProcedure;
                        cmdPago.Parameters.AddWithValue("@p_Id_pago", nuevoIdPago);
                        cmdPago.Parameters.AddWithValue("@p_Id_pedido", nuevoIdPedido);
                        cmdPago.Parameters.AddWithValue("@p_Monto_pagado", totalPagado);
                        cmdPago.Parameters.AddWithValue("@p_Fecha_pago", DateTime.Now.Date);
                        cmdPago.Parameters.AddWithValue("@p_Metodo_pago", metodoPago);
                        cmdPago.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    return nuevoIdPedido;
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }
            }
        }

        private static int ObtenerSiguienteId(SqlConnection conn, SqlTransaction tx, string tabla, string columna)
        {
            string sql = $"SELECT ISNULL(MAX({columna}), 0) + 1 FROM {tabla}";
            using (SqlCommand cmd = new SqlCommand(sql, conn, tx))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}