using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaPersistente;

namespace capaLógica
{
    public class UBajaUsuario
    {
        private UBaja BajaUsuario;

        public UBajaUsuario()
        {
            BajaUsuario = new UBaja();
        }

        public bool DarDeBajaUsuario(int usuarioCi)
        {
            return BajaUsuario.DarDeBajaUsuario(usuarioCi);
        }
    }
}
