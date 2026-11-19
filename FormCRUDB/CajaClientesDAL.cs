using System;
using System.Data;
using System.Data.SqlClient;

namespace FormCRUDB
{
    public class CajaClientesDAL
    {
        // ==========================================
        // 1. MÉTODOS PARA CIERRE DE CAJA (Tabla Pagos)
        // ==========================================
        public static DataTable ObtenerPagosPorFecha(DateTime fecha)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT pg.Id_pago AS [Pago #],
                                      pg.Id_pedido AS [Pedido #],
                                      c.Nombre + ' ' + c.Apellido AS Cliente,
                                      pg.Metodo_pago AS [Método],
                                      pg.Monto_pagado AS Monto,
                                      p.Estado_pedido AS [Estado Orden]
                               FROM Pagos pg
                               INNER JOIN Pedidos p ON pg.Id_pedido = p.Id_pedido
                               INNER JOIN Clientes c ON p.Id_cliente = c.Id_cliente
                               WHERE pg.Fecha_pago = @Fecha
                               ORDER BY pg.Id_pago DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // ==========================================
        // 2. MÉTODOS PARA CLIENTES Y SP HISTORIAL
        // ==========================================
        public static DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT Id_cliente AS ID, Nombre, Apellido, Telefono AS Teléfono, Direccion AS Dirección FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static bool AgregarCliente(string nombre, string apellido, string telefono, string direccion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();

                // Calculamos el siguiente ID porque Clientes no tiene IDENTITY en SQL
                int nuevoId = 1;
                using (SqlCommand cmdId = new SqlCommand("SELECT ISNULL(MAX(Id_cliente), 0) + 1 FROM Clientes", conn))
                {
                    nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                string sql = @"INSERT INTO Clientes (Id_cliente, Nombre, Apellido, Telefono, Direccion)
                               VALUES (@Id, @Nombre, @Apellido, @Telefono, @Direccion)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", nuevoId);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrWhiteSpace(direccion) ? (object)DBNull.Value : direccion);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool ActualizarCliente(int idCliente, string nombre, string apellido, string telefono, string direccion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = @"UPDATE Clientes 
                               SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion 
                               WHERE Id_cliente = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idCliente);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrWhiteSpace(direccion) ? (object)DBNull.Value : direccion);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Ejecuta el Procedimiento Almacenado sp_ObtenerPedidosPorCliente
        public static DataTable ObtenerPedidosPorCliente(int idCliente)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerPedidosPorCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Id_cliente", idCliente);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}