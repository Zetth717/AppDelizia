using capaLógica;
using claseGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaGUI
{
    public partial class UBaja : Form
    {
        private UObtenerUsuario usuarioLogica;
        private UBajaUsuario bajaUsuario;
        public UBaja()
        {
            bajaUsuario = new UBajaUsuario();
            InitializeComponent();
            usuarioLogica = new UObtenerUsuario();
            CargarUsuarios();
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

        private void butnVolver_Click(object sender, EventArgs e)
        {
            Admin nuevoFormulario = new Admin();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana.Arrastrar(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int usuarioCi = ObtenerIdUsuarioSeleccionado(); // Supón que obtienes el ID del usuario seleccionado
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
    }
 }
