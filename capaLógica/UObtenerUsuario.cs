using capaPersistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLógica
{
    public class UObtenerUsuario
    {
        public Uobtener usuarioPersistencia;

        public UObtenerUsuario()
        {
            usuarioPersistencia = new Uobtener();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioPersistencia.ObtenerUsuarios();
        }

        // Método para obtener la lista de usuarios formateados como strings
        public List<string> CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioPersistencia.ObtenerUsuarios();
            List<string> listaFormateada = new List<string>();

            // Convertimos cada usuario en una cadena de texto usando el método ToString
            foreach (Usuario usuario in usuarios)
            {
                listaFormateada.Add(usuario.ToString());
            }

            return listaFormateada;
        }

        public bool ActivarUsuario(int ci)
        {
            return usuarioPersistencia.ActivarUsuarioPorCi(ci);
        }
    }
}
