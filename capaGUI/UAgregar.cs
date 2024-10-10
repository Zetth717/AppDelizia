using capaLógica;
using claseGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaGUI
{
    public partial class UAgregar : Form
    {
        public UAgregar()
        {
            InitializeComponent();
            // Establece placeholder al cargar el formulario
            //SetPlaceholders();
            // Inicializa la clase lógica
            gestionUsuario = new GestiónUsuario();
        }

        /* Establece los placeholders para ambos TextBox al cargar el formulario
        private void SetPlaceholders()
        {
            // Placeholder para txtNombre
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }

            // Placeholder para txtApellido
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        // Evento cuando el txtNombre recibe el foco
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.Black;
        }

            // Evento cuando el textBoxUser pierde el foco
            private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Gray;
        }

        // Evento cuando el txtApellido recibe el foco
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtApellido.ForeColor = Color.Black;
        }

        // Evento cuando el textBoxUser pierde el foco
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            txtApellido.Text = "Apellido";
            txtApellido.ForeColor = Color.Gray;
        }

        */

        private void butnVolver_Click(object sender, EventArgs e)
        {
            PADM nuevoFormulario = new PADM();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private GestiónUsuario gestionUsuario;

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            int id, ci, telefono, clave;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La cédula debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtTel.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtClave.Text, out clave))
            {
                MessageBox.Show("La clave debe ser un número válido.");
                return;
            }

            // Capturamos los valores de los otros controles
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string rol = txtRol.Text;

            // Asegurarnos de que todos los campos de texto estén llenos antes de proceder
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Llamamos a la clase lógica para registrar el usuario
            bool resultado = gestionUsuario.RegistrarUsuario(id, ci, nombre, apellido, telefono, clave, rol);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana.Arrastrar(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
