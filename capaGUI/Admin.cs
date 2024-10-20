using capaGUI;
using capaLógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseGUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void butnVolver_Click(object sender, EventArgs e)
        {
            Login nuevoFormulario = new Login();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            PAgregar nuevoFormulario = new PAgregar();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana.Arrastrar(this);
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            UAgregar nuevoFormulario = new UAgregar();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void btnDelUsuario_Click(object sender, EventArgs e)
        {
            UBaja nuevoFormulario = new UBaja();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            PLista nuevoFormulario = new PLista();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }
    }
}
