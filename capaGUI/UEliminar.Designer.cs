namespace capaGUI
{
    partial class UEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UEliminar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.butnVolver = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listUsuarios);
            this.groupBox1.Controls.Add(this.btnEliminarUsuario);
            this.groupBox1.Controls.Add(this.butnVolver);
            this.groupBox1.Location = new System.Drawing.Point(493, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 554);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // listUsuarios
            // 
            this.listUsuarios.BackColor = System.Drawing.Color.Peru;
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.Location = new System.Drawing.Point(6, 11);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(383, 407);
            this.listUsuarios.TabIndex = 8;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Peru;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(146, 431);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(99, 38);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // butnVolver
            // 
            this.butnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.butnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butnVolver.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnVolver.Location = new System.Drawing.Point(208, 504);
            this.butnVolver.Name = "butnVolver";
            this.butnVolver.Size = new System.Drawing.Size(181, 44);
            this.butnVolver.TabIndex = 6;
            this.butnVolver.Text = "Volver";
            this.butnVolver.UseVisualStyleBackColor = false;
            this.butnVolver.Click += new System.EventHandler(this.butnVolver_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.Transparent;
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.btnSalir);
            this.panelBarra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelBarra.Location = new System.Drawing.Point(-2, 1);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(903, 37);
            this.panelBarra.TabIndex = 14;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::capaGUI.Properties.Resources.delete_14793494;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(838, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::capaGUI.Properties.Resources.Cerrar1;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(869, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // UEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capaGUI.Properties.Resources.LogoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UEliminar";
            this.groupBox1.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button butnVolver;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}