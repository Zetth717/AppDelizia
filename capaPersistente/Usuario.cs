﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersistente
{
    public class Usuario
    {
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {CI}";
        }
    }
}
