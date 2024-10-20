using capaPersistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLógica
{
    public class UAltaLógica
    {
        private UAlta usuarioAlta;

        public UAltaLógica()
        {
            usuarioAlta = new UAlta(); // Inicializa el servicio de usuario
        }

        public bool ActivarUsuarioPorCi(int ci)
        {
            return usuarioAlta.ActivarUsuarioPorCi(ci);
        }
    }
}
