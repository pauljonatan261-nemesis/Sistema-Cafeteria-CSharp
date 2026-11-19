using System;
using System.Data;
using System.Data.SqlClient;

namespace FormCRUDB
{
    public class CocinaDAL
    {
        // Obtiene todos los pedidos en estado 'Pendiente' con el nombre del cliente
        public static DataTable ObtenerPedidosPendientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT p.Id_pedido AS [Pedido #], 
                                      c.Nombre + ' ' + c.Apellido AS Cliente, 
                                      p.Fecha_pedido AS Fecha, 
                                      p.Estado_pedido AS Estado
                               FROM Pedidos p
                               INNER JOIN Clientes c ON p.Id_cliente = c.Id_cliente
                               WHERE p.Estado_pedido = 'Pendiente'
                               ORDER BY p.Id_pedido ASC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Obtiene los productos y cantidades de un pedido específico
        public static DataTable ObtenerDetallePedido(int idPedido)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = @"SELECT pr.Producto, 
                                      dp.Cantidad AS Cant, 
                                      pr.Categoria AS Categoría
                               FROM Detalle_Pedido dp
                               INNER JOIN Productos pr ON dp.Id_producto = pr.Id
                               WHERE dp.Id_pedido = @Id_pedido";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_pedido", idPedido);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Cambia el estado del pedido a 'Entregado'
        public static bool MarcarComoEntregado(int idPedido)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string sql = "UPDATE Pedidos SET Estado_pedido = 'Entregado' WHERE Id_pedido = @Id_pedido";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_pedido", idPedido);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cancela el pedido y devuelve las unidades al stock de la tabla Productos
        public static void CancelarPedido(int idPedido)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                try
                {
                    // 1. Devolver stock a Productos
                    string sqlDevolverStock = @"UPDATE pr
                                                SET pr.Cantidad = pr.Cantidad + dp.Cantidad
                                                FROM Productos pr
                                                INNER JOIN Detalle_Pedido dp ON pr.Id = dp.Id_producto
                                                WHERE dp.Id_pedido = @Id_pedido";
                    using (SqlCommand cmdStock = new SqlCommand(sqlDevolverStock, conn, tx))
                    {
                        cmdStock.Parameters.AddWithValue("@Id_pedido", idPedido);
                        cmdStock.ExecuteNonQuery();
                    }

                    // 2. Actualizar estado a 'Cancelado'
                    string sqlEstado = "UPDATE Pedidos SET Estado_pedido = 'Cancelado' WHERE Id_pedido = @Id_pedido";
                    using (SqlCommand cmdEstado = new SqlCommand(sqlEstado, conn, tx))
                    {
                        cmdEstado.Parameters.AddWithValue("@Id_pedido", idPedido);
                        cmdEstado.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}