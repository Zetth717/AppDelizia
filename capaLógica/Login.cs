using capaPersistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLógica
{
    public class Login
    {
        public DUsuario datos = new DUsuario();

        public string VerificarUsuarioYObtenerRol(string nombre, string clave)
        {
            return datos.VerificarUsuarioYObtenerRol(nombre, clave);
            throw new NotImplementedException();
        }
    }
    }

    

