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
        public UsuarioPersistencia usuarioPersistencia;

        public UObtenerUsuario()
        {
            usuarioPersistencia = new UsuarioPersistencia();
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
    }
}
