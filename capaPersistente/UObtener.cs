using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaPersistente;

namespace capaPersistente
{
    public class UsuarioPersistencia
    {
        private ConexionDB conexionDB;

        public UsuarioPersistencia()
        {
            conexionDB = new ConexionDB();
        }

        // Método para obtener la lista de usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            string query = "SELECT ci, nombre, apellido, telefono FROM usuario";

            MySqlConnection conexion = conexionDB.getConexion();
            MySqlCommand command = new MySqlCommand(query, conexion);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Crear el objeto Usuario
                Usuario usuario = new Usuario
                {
                    CI = reader["ci"].ToString(),
                    Nombre = reader["nombre"].ToString(),
                    Apellido = reader["apellido"].ToString(),
                    Telefono = reader["telefono"].ToString()
                };

                // Añadir el usuario a la lista
                listaUsuarios.Add(usuario);
            }

            reader.Close();
            return listaUsuarios;
        }
    }
}