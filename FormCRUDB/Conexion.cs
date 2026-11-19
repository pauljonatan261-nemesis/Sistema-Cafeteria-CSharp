using System.Configuration;
using System.Data.SqlClient;

namespace FormCRUDB
{
    public class Conexion
    {
        // Lee la cadena "CafeteriaDB" configurada en el App.config
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["CafeteriaDB"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}