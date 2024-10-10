using System;
using capaPersistente;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace capaLógica
{
    public class ProbarConexion
    {
        private VerificarConexionDB VConexion = new VerificarConexionDB();

        // Método para llamar a ProbarConexion y retornar si la conexión es correcta
        public bool ProbarConexionDB()
        {
            // Llamamos al método ProbarConexion de la clase VerificarConexionDB
            bool conexionExitosa = VConexion.ProbarConexion();
            return conexionExitosa;
        }

    } 
}
