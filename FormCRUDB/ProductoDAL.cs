using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FormCRUDB
{
    public class ProductoDAL
    {
        // Descontar la cantidad vendida del inventario en SQL Server
        public static bool DescontarStock(int idProducto, int cantidadVendida)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Cantidad = Cantidad - @CantidadVendida WHERE Id = @Id AND Cantidad >= @CantidadVendida";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", idProducto);
                cmd.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // READ: Obtener la lista completa de productos desde la BD
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "SELECT Id, Producto, Precio, Categoria, Cantidad FROM Productos";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Producto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Producto"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Categoria = reader["Categoria"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"])
                    });
                }
            }
            return lista;
        }

        // CREATE: Insertar un nuevo producto
        public static bool AgregarProducto(Producto prod)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Productos (Producto, Precio, Categoria, Cantidad) " +
                               "VALUES (@Nombre, @Precio, @Categoria, @Cantidad)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@Precio", prod.Precio);
                cmd.Parameters.AddWithValue("@Categoria", prod.Categoria);
                cmd.Parameters.AddWithValue("@Cantidad", prod.Cantidad);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // UPDATE: Actualizar un producto existente
        public static bool ModificarProducto(Producto prod)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Producto=@Nombre, Precio=@Precio, Categoria=@Categoria, Cantidad=@Cantidad " +
                               "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", prod.Id);
                cmd.Parameters.AddWithValue("@Nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@Precio", prod.Precio);
                cmd.Parameters.AddWithValue("@Categoria", prod.Categoria);
                cmd.Parameters.AddWithValue("@Cantidad", prod.Cantidad);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // DELETE: Eliminar un producto por su Id
        public static bool EliminarProducto(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Productos WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }


}