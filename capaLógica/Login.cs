using capaPersistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace capaLógica
{
    public class Login
    {
        private ConexionDB conexionDB = new ConexionDB();

        // Método para verificar si el usuario existe en la base de datos
        public bool VerificarUsuario(string nombre, string clave)
        {
            try
            {
                // Obtener la conexión de la capa persistente
                using (MySqlConnection conexion = conexionDB.getConexion())
                {
                    // Crear la consulta SQL
                    string query = "SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND clave = @clave";

                    // Crear el comando con la consulta y la conexión
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asignar parámetros para prevenir inyecciones SQL
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@clave", clave);

                        // Ejecutar la consulta y obtener el número de filas coincidentes
                        int count = Convert.ToInt32(comando.ExecuteScalar());

                        // Si se encontró un usuario, el count será mayor a 0
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar el usuario: " + ex.Message);
                return false; // Retorna falso si hay un error
            }
        }

    }
}
