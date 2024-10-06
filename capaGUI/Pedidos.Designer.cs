namespace claseGUI
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.groupBoxPedidos = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnListaPedidos = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBoxDirección = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgergar = new System.Windows.Forms.Button();
            this.groupBoxPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPedidos
            // 
            this.groupBoxPedidos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPedidos.Controls.Add(this.btnAgergar);
            this.groupBoxPedidos.Controls.Add(this.textBoxDirección);
            this.groupBoxPedidos.Controls.Add(this.listBox1);
            this.groupBoxPedidos.Controls.Add(this.textBoxApellido);
            this.groupBoxPedidos.Controls.Add(this.textBoxNombre);
            this.groupBoxPedidos.Controls.Add(this.textBoxTel);
            this.groupBoxPedidos.Controls.Add(this.comboBox3);
            this.groupBoxPedidos.Controls.Add(this.comboBox1);
            this.groupBoxPedidos.Controls.Add(this.btnListaPedidos);
            this.groupBoxPedidos.Controls.Add(this.btnAgregarPedido);
            this.groupBoxPedidos.Controls.Add(this.btnVolver);
            this.groupBoxPedidos.Location = new System.Drawing.Point(493, 12);
            this.groupBoxPedidos.Name = "groupBoxPedidos";
            this.groupBoxPedidos.Size = new System.Drawing.Size(395, 576);
            this.groupBoxPedidos.TabIndex = 1;
            this.groupBoxPedidos.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(208, 526);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(181, 44);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.Peru;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(208, 414);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(181, 44);
            this.btnAgregarPedido.TabIndex = 1;
            this.btnAgregarPedido.Text = "Crear pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.BackColor = System.Drawing.Color.Peru;
            this.btnListaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaPedidos.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPedidos.Location = new System.Drawing.Point(7, 526);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(181, 44);
            this.btnListaPedidos.TabIndex = 2;
            this.btnListaPedidos.Text = "Lista de pedidos";
            this.btnListaPedidos.UseVisualStyleBackColor = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(208, 257);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(181, 31);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(208, 294);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(181, 31);
            this.textBoxApellido.TabIndex = 4;
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTel.Location = new System.Drawing.Point(208, 331);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(181, 31);
            this.textBoxTel.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(349, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(40, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // textBoxDirección
            // 
            this.textBoxDirección.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxDirección.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirección.Location = new System.Drawing.Point(208, 368);
            this.textBoxDirección.Name = "textBoxDirección";
            this.textBoxDirección.Size = new System.Drawing.Size(181, 31);
            this.textBoxDirección.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 459);
            this.listBox1.TabIndex = 11;
            // 
            // btnAgergar
            // 
            this.btnAgergar.BackColor = System.Drawing.Color.Peru;
            this.btnAgergar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgergar.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgergar.Location = new System.Drawing.Point(208, 54);
            this.btnAgergar.Name = "btnAgergar";
            this.btnAgergar.Size = new System.Drawing.Size(181, 44);
            this.btnAgergar.TabIndex = 12;
            this.btnAgergar.Text = "Agregar producto";
            this.btnAgergar.UseVisualStyleBackColor = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capaGUI.Properties.Resources.LogoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBoxPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.groupBoxPedidos.ResumeLayout(false);
            this.groupBoxPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPedidos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnListaPedidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxDirección;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgergar;
    }
}