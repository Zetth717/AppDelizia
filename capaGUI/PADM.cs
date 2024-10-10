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
    public partial class PADM : Form
    {
        public PADM()
        {
            InitializeComponent();
        }

        private void butnVolver_Click(object sender, EventArgs e)
        {
            P1 nuevoFormulario = new P1();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos nuevoFormulario = new Pedidos();
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
            UEliminar nuevoFormulario = new UEliminar();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }
    }
}
