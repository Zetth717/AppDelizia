using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersistente
{
    public class UAlta
    {
        private ConexionDB conexionDB;

        public UAlta()
        {
            conexionDB = new ConexionDB();
        }

        public bool ActivarUsuarioPorCi(int ci)
        {
            MySqlConnection conexion = null;
            try
            {
                // Abre la conexión
                conexion = conexionDB.getConexion();

                // Verificamos si el usuario existe y está inactivo (Estado = 0)
                string verificarQuery = "SELECT COUNT(*) FROM usuario WHERE ci = @ci AND Estado = 0";
                MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conexion);
                verificarCmd.Parameters.AddWithValue("@ci", ci);

                int usuarioInactivo = Convert.ToInt32(verificarCmd.ExecuteScalar());

                // Si no existe el usuario o ya está activo, retornamos false
                if (usuarioInactivo == 0)
                {
                    return false;
                }

                // Si existe el usuario y está inactivo, procedemos a activarlo (Estado = 1)
                string actualizarQuery = "UPDATE usuario SET Estado = 1 WHERE ci = @ci";
                MySqlCommand actualizarCmd = new MySqlCommand(actualizarQuery, conexion);
                actualizarCmd.Parameters.AddWithValue("@ci", ci);

                int filasAfectadas = actualizarCmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejo de errores, puedes lanzar la excepción o loguearla
                Console.WriteLine("Error al activar el usuario: " + ex.Message);
                return false;
            }
            finally
            {
                // Asegúrate de cerrar la conexión si fue abierta
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
