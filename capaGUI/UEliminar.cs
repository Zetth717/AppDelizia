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
    public partial class UEliminar : Form
    {
        public UEliminar()
        {
            InitializeComponent();
        }

        private void butnVolver_Click(object sender, EventArgs e)
        {
            PADM nuevoFormulario = new PADM();
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
    }
}
