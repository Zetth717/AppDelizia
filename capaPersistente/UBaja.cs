using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersistente
{
    public class UBaja
    {
        private ConexionDB db;

        public UBaja()
        {
            db = new ConexionDB();
        }

        public bool DarDeBajaUsuario(int usuarioCi)
        {
            try
            {
                using (MySqlConnection connection = db.getConexion()) // Usamos getConexion()
                {
                    {
                        string query = "UPDATE usuario SET Estado = 0 WHERE ci = @ci";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ci", usuarioCi);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes capturar el error y loguearlo o mostrar un mensaje específico
                Console.WriteLine("Error al dar de baja al usuario: " + ex.Message);
                return false;
            }

        }
    }
}
