using capaPersistente;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersistencia
{
    public class IngresarUsuario
    {
        public ConexionDB ingresarUsuario;

        // Constructor de la clase
        public IngresarUsuario()
        {
            // Inicializamos la conexión a la base de datos
            ingresarUsuario = new ConexionDB();
        }

        // Método para insertar un usuario en la base de datos
        public bool InsertarUsuario(int id, int ci, string nombre, string apellido, int telefono, int clave, string rol)
        {
            // Validar que los campos no estén vacíos o con los placeholders
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
        ci <= 0 || telefono <= 0 || clave <= 0 || string.IsNullOrEmpty(rol))
            {
                throw new ArgumentException("Debe completar todos los campos.");
            }

            // Conectar a la base de datos y realizar la inserción
            try
            {
                // Obtenemos la conexión desde la clase ConexionDB
                using (MySqlConnection conexion = ingresarUsuario.getConexion())
                {
                    string query = "INSERT INTO usuario (nombre, apellido) VALUES (@nombre, @apellido)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ci", ci);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@clave", clave);
                        cmd.Parameters.AddWithValue("@rol", rol);

                        // Ejecutar la inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Si se insertaron filas, retorna true
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}