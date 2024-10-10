using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersistente
{
    public class VerificarConexionDB
    {
        private ConexionDB conexionDB = new ConexionDB();

        // Método para verificar la conexión
        public bool ProbarConexion()
        {
            try
            {
                // Obtener la conexión desde la capa persistente
                MySqlConnection conexion = conexionDB.getConexion();

                // Verificamos si la conexión está abierta
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    return true;  // Hay conexión
                }
                else
                {
                    return false;  // No hay conexión
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar conectar: " + ex.Message);
                return false;
            }

        }
    }
}
