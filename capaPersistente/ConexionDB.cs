using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace capaPersistente
{
    public class ConexionDB
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "delizia";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public ConexionDB() 
        {
            cadenaConexion = $"Server={server};Database={database};User Id={user};Password={password};";
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

            }
            return conexion;
        }
    }
}
