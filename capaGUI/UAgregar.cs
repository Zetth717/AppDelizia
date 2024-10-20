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
        private UObtenerUsuario usuarioLogica;
        private UBajaUsuario bajaUsuario;
        private UAltaLógica usuarioAlta;
        public UAgregar()
        {
            InitializeComponent();
            // Inicializa la clase lógica
            bajaUsuario = new UBajaUsuario();
            usuarioLogica = new UObtenerUsuario();
            usuarioAlta = new UAltaLógica();
            CargarUsuarios();
            gestionUsuario = new GestiónUsuario();
            // Agregar los nombres al ComboBox
            Rol.Items.Add("ADMINISTRADOR");
            Rol.Items.Add("COCINA");
            Rol.Items.Add("PEDIDOS");
            Rol.Items.Add("REPARTO");
        }

        private void CargarUsuarios()
        {
            // Obtenemos la lista de cadenas formateadas desde la capa lógica
            List<string> usuariosFormateados = usuarioLogica.CargarUsuarios();

            // Limpiamos el ListBox antes de agregar elementos
            listUsuarios.Items.Clear();

            // Añadimos los usuarios formateados al ListBox
            foreach (string usuarioFormateado in usuariosFormateados)
            {
                listUsuarios.Items.Add(usuarioFormateado);
            }
        }

        private int ObtenerIdUsuarioSeleccionado()
        {
            if (listUsuarios.SelectedItem != null)
            {
                // Obtenemos la cadena seleccionada, que tiene el formato "Nombre Apellido - CI"
                string usuarioSeleccionado = listUsuarios.SelectedItem.ToString();

                // Suponemos que el formato es "Nombre Apellido - CI", y extraemos el CI
                // Usamos Split para dividir el string por el guión ("-") y luego obtener el CI
                string[] partes = usuarioSeleccionado.Split('-');

                if (partes.Length == 2)
                {
                    string ciString = partes[1].Trim(); // Obtenemos el CI, eliminamos espacios en blanco
                    return Convert.ToInt32(ciString);   // Convertimos el CI a entero
                }
                else
                {
                    MessageBox.Show("Formato de usuario no válido.");
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario.");
                return -1;
            }
        }

        private GestiónUsuario gestionUsuario;

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            int ci, clave;

            if (!int.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La cédula debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtClave.Text, out clave))
            {
                MessageBox.Show("La clave debe ser un número válido.");
                return;
            }

            // Capturamos los valores de los otros controles
            string telefono = txtTel.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //string rol = txtRol.Text;
            string rol = Rol.SelectedItem?.ToString();

            // Asegurarnos de que todos los campos de texto estén llenos antes de proceder
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Llamamos a la clase lógica para registrar el usuario
            bool resultado = gestionUsuario.RegistrarUsuario(ci, nombre, apellido, telefono, clave, rol);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado exitosamente.");
                // Limpiar los TextBox
                txtCi.Text = "";
                txtClave.Text = "";
                txtTel.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";

                // Restablecer el ComboBox
                Rol.SelectedIndex = -1; // Deseleccionar el ComboBox
                CargarUsuarios();
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

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            // Obtiene el ID del usuario seleccionado
            int usuarioCi = ObtenerIdUsuarioSeleccionado();
            bool exito = bajaUsuario.DarDeBajaUsuario(usuarioCi);

            if (exito)
            {
                MessageBox.Show("Usuario dado de baja exitosamente.");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo dar de baja al usuario.");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int ci;

            // Valida si el valor ingresado es un número entero válido
            if (!int.TryParse(txtAlta.Text, out ci))
            {
                MessageBox.Show("Por favor, ingrese una cédula de identidad válida.");
                return;
            }

            // Llama a la lógica para activar al usuario con esa CI
            bool resultado = usuarioAlta.ActivarUsuarioPorCi(ci);

            if (resultado)
            {
                MessageBox.Show("Usuario activado exitosamente.");
                // Refresca el ListBox3
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo activar el usuario. Verifique que la CI sea correcta o que el usuario esté inactivo.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Admin nuevoFormulario = new Admin();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }
    }
}
