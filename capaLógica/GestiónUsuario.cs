﻿using capaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLógica
{
    public class GestiónUsuario
    {
        private IngresarUsuario ingresarUsuario;

        public GestiónUsuario()
        {
            // Instanciamos la clase de la capa persistente para acceder a la base de datos
            ingresarUsuario = new IngresarUsuario();
        }

        // Método para insertar un usuario llamando a la capa persistente
        public bool RegistrarUsuario(int id, int ci, string nombre, string apellido, int telefono, int clave, string rol)
        {
            // Aquí puedes agregar cualquier validación extra de la lógica de negocio si es necesario.

            // Luego llamamos a la capa persistente para insertar el usuario en la base de datos
            try
            {
                return ingresarUsuario.InsertarUsuario(id, ci, nombre, apellido, telefono, clave, rol);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}