using capaPersistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace capaLógica
{
    public class Login
    {
        private ConexionDB conexionDB = new ConexionDB();

        // Método para verificar el usuario y obtener el rol
        public string VerificarUsuarioYObtenerRol(string nombre, string clave)
        {
            try
            {
                using (MySqlConnection conexion = conexionDB.getConexion())
                {
                    string query = "SELECT rol FROM usuario WHERE nombre = @nombre AND clave = @clave";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@clave", clave);

                        string rol = (string)comando.ExecuteScalar();

                        if (rol != null)
                        {
                            return rol;  // Retorna el rol si es correcto
                        }
                        else
                        {
                            return null;  // Retorna null si no coincide el usuario o clave
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar usuario: " + ex.Message);
                return null;
            }
        }
    }
}

    

