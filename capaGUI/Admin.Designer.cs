namespace claseGUI
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnGestión = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butnVolver = new System.Windows.Forms.Button();
            this.btnButton2 = new System.Windows.Forms.Button();
            this.btnDelUsuario = new System.Windows.Forms.Button();
            this.btnReparto = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestión
            // 
            this.btnGestión.BackColor = System.Drawing.Color.Peru;
            this.btnGestión.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestión.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestión.ForeColor = System.Drawing.Color.Black;
            this.btnGestión.Location = new System.Drawing.Point(6, 19);
            this.btnGestión.Name = "btnGestión";
            this.btnGestión.Size = new System.Drawing.Size(181, 44);
            this.btnGestión.TabIndex = 0;
            this.btnGestión.Text = "Gestión";
            this.btnGestión.UseVisualStyleBackColor = false;
            this.btnGestión.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.butnVolver);
            this.groupBox1.Controls.Add(this.btnButton2);
            this.groupBox1.Controls.Add(this.btnDelUsuario);
            this.groupBox1.Controls.Add(this.btnReparto);
            this.groupBox1.Controls.Add(this.btnCocina);
            this.groupBox1.Controls.Add(this.btnPedidos);
            this.groupBox1.Controls.Add(this.btnGestión);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 544);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // butnVolver
            // 
            this.butnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.butnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butnVolver.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnVolver.Location = new System.Drawing.Point(689, 494);
            this.butnVolver.Name = "butnVolver";
            this.butnVolver.Size = new System.Drawing.Size(181, 44);
            this.butnVolver.TabIndex = 6;
            this.butnVolver.Text = "Volver";
            this.butnVolver.UseVisualStyleBackColor = false;
            this.butnVolver.Click += new System.EventHandler(this.butnVolver_Click);
            // 
            // btnButton2
            // 
            this.btnButton2.BackColor = System.Drawing.Color.Peru;
            this.btnButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton2.Location = new System.Drawing.Point(6, 119);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Size = new System.Drawing.Size(181, 44);
            this.btnButton2.TabIndex = 5;
            this.btnButton2.Text = "Button2";
            this.btnButton2.UseVisualStyleBackColor = false;
            // 
            // btnDelUsuario
            // 
            this.btnDelUsuario.BackColor = System.Drawing.Color.Peru;
            this.btnDelUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUsuario.Location = new System.Drawing.Point(6, 69);
            this.btnDelUsuario.Name = "btnDelUsuario";
            this.btnDelUsuario.Size = new System.Drawing.Size(181, 44);
            this.btnDelUsuario.TabIndex = 4;
            this.btnDelUsuario.Text = "Button";
            this.btnDelUsuario.UseVisualStyleBackColor = false;
            this.btnDelUsuario.Click += new System.EventHandler(this.btnDelUsuario_Click);
            // 
            // btnReparto
            // 
            this.btnReparto.BackColor = System.Drawing.Color.Peru;
            this.btnReparto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReparto.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparto.Location = new System.Drawing.Point(208, 119);
            this.btnReparto.Name = "btnReparto";
            this.btnReparto.Size = new System.Drawing.Size(181, 44);
            this.btnReparto.TabIndex = 3;
            this.btnReparto.Text = "Reparto";
            this.btnReparto.UseVisualStyleBackColor = false;
            // 
            // btnCocina
            // 
            this.btnCocina.BackColor = System.Drawing.Color.Peru;
            this.btnCocina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCocina.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocina.Location = new System.Drawing.Point(208, 69);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(181, 44);
            this.btnCocina.TabIndex = 2;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.UseVisualStyleBackColor = false;
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Peru;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(208, 19);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(181, 44);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmin.Controls.Add(this.pictureBox1);
            this.panelAdmin.Controls.Add(this.btnMinimizar);
            this.panelAdmin.Controls.Add(this.btnSalir);
            this.panelAdmin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelAdmin.Location = new System.Drawing.Point(-2, 1);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(903, 37);
            this.panelAdmin.TabIndex = 10;
            this.panelAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAdmin_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::capaGUI.Properties.Resources.Volver;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(797, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::capaGUI.Properties.Resources.Minimizar;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(833, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::capaGUI.Properties.Resources.Cerrar;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(869, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::capaGUI.Properties.Resources.FondoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PADM";
            this.groupBox1.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestión;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReparto;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnButton2;
        private System.Windows.Forms.Button btnDelUsuario;
        private System.Windows.Forms.Button butnVolver;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}