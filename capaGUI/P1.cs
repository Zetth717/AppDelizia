using System;
using capaLógica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseGUI
{
    public partial class P1 : Form
    {
        // Instancia de la capa lógica
        private Logica logica = new Logica();
        public P1()
        {
            InitializeComponent();
            SetPlaceholders(); // Establece placeholder al cargar el formulario
            CambiarIdioma(); // Inicializa el idioma por defecto (español en este caso)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            // Cambia el valor de la variable para alternar el idioma
            idiomaIngles = !idiomaIngles;

            // Cambiar los textos según el idioma seleccionado
            CambiarIdioma();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Establece los placeholders para ambos TextBox al cargar el formulario
        private void SetPlaceholders()
        {
            if (idiomaIngles)
            {
                // Placeholder para textBoxUser en inglés
                if (string.IsNullOrEmpty(textBoxUser.Text)) 
                {
                    textBoxUser.Text = "Username";
                    textBoxUser.ForeColor = Color.Gray;
                }
                // Placeholder para textBox2 en inglés
                if (string.IsNullOrEmpty(textBoxPsw.Text)) 
                {
                    textBoxPsw.Text = "Password";
                    textBoxPsw.ForeColor = Color.Gray;
                    textBoxPsw.UseSystemPasswordChar = false;  
                }
            }
            else
            {
                // Placeholder para textBoxUser en español
                if (string.IsNullOrEmpty(textBoxUser.Text))
                {
                    textBoxUser.Text = "Usuario";
                    textBoxUser.ForeColor = Color.Gray;
                }
                // Placeholder para textBox2 en español
                if (string.IsNullOrEmpty(textBoxPsw.Text))
                {
                    return;
                }
                textBoxPsw.Text = "Contraseña";
                textBoxPsw.ForeColor = Color.Gray;
                textBoxPsw.UseSystemPasswordChar = false;
            }
        }

        // Evento cuando el textBoxUser recibe el foco
        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Usuario")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
            }
            if (textBoxUser.Text == "Username")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
            }
        }

        // Evento cuando el textBoxUser pierde el foco
        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" & idiomaIngles == true)
            {
                textBoxUser.Text = "Usuario";
                textBoxUser.ForeColor = Color.Gray;
            }
            if (textBoxUser.Text == "" & idiomaIngles == false)
            {
                textBoxUser.Text = "Username";
                textBoxUser.ForeColor = Color.Gray;
            }
        }

        // Evento cuando el textBoxPsw recibe el foco
        private void textBoxPsw_Enter(object sender, EventArgs e)
        {
            if (textBoxPsw.Text == "Contraseña")
            {
                textBoxPsw.Text = "";
                textBoxPsw.ForeColor = Color.Black;
                textBoxPsw.UseSystemPasswordChar = true;
            }
            if (textBoxPsw.Text == "Password")
            {
                textBoxPsw.Text = "";
                textBoxPsw.ForeColor = Color.Black;
                textBoxPsw.UseSystemPasswordChar = true;
            }

        }

        // Evento cuando el textBoxPsw pierde el foco
        private void textBoxPsw_Leave(object sender, EventArgs e)
        {
            if (textBoxPsw.Text == "" & idiomaIngles == true)
            {
                textBoxPsw.Text = "Contraseña";
                textBoxPsw.ForeColor = Color.Gray;
                textBoxPsw.UseSystemPasswordChar = false;
            }
            if (textBoxPsw.Text == "" & idiomaIngles == false)
            {
                textBoxPsw.Text = "Password";
                textBoxPsw.ForeColor = Color.Gray;
                textBoxPsw.UseSystemPasswordChar = false;
            }
        }

        //Evento para el idioma

        private bool idiomaIngles = true; // true para español, false para inglés;

        private void CambiarIdioma()
        {
            if (idiomaIngles)
            {
                // Cambiar a español
                btnEnter.Text = "Entrar";
                btnExit.Text = "Salir";
                labelInicio.Text = "Inicio";
                textBoxUser.Text = "Usuario";
                textBoxPsw.Text = "Contraseña";
            }
            else
            {
                // Cambiar a inglés
                btnEnter.Text = "Enter";
                btnExit.Text = "Exit";
                labelInicio.Text = "Login";
                textBoxUser.Text = "Username";
                textBoxPsw.Text = "Password";
            }
        }
        //Fin evento Idioma

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            // Llama al método ProbarConexion de la capa lógica
            bool hayConexion = logica.ProbarConexion();

            // Mostrar un mensaje indicando el estado de la conexión
            if (hayConexion)
            {
                MessageBox.Show("Conexión exitosa con la base de datos.", "Estado de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Estado de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
