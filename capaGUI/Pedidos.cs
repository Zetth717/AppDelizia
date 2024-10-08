﻿using capaLógica;
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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PADM nuevoFormulario = new PADM();
            nuevoFormulario.Show();

            // Cerrar o esconder el formulario actual (Form1)
            this.Hide();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelInicio_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana.Arrastrar(this);
        }
    }
}
