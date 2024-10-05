namespace claseGUI
{
    partial class P1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1));
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.labelInicio = new System.Windows.Forms.Label();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.groupBoxInicio = new System.Windows.Forms.GroupBox();
            this.groupBoxInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Peru;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(39, 271);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 38);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Entrar";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(153, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(39, 174);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(213, 31);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPsw.Location = new System.Drawing.Point(39, 218);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(213, 31);
            this.textBoxPsw.TabIndex = 4;
            this.textBoxPsw.UseSystemPasswordChar = true;
            this.textBoxPsw.Enter += new System.EventHandler(this.textBoxPsw_Enter);
            this.textBoxPsw.Leave += new System.EventHandler(this.textBoxPsw_Leave);
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.BackColor = System.Drawing.Color.Transparent;
            this.labelInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInicio.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicio.ForeColor = System.Drawing.Color.Peru;
            this.labelInicio.Location = new System.Drawing.Point(79, 104);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(126, 65);
            this.labelInicio.TabIndex = 5;
            this.labelInicio.Text = "Inicio";
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Location = new System.Drawing.Point(162, 95);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(43, 17);
            this.btnLang.TabIndex = 6;
            this.btnLang.Text = "ES/EN";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.Peru;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(795, 564);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(93, 24);
            this.btnPrueba.TabIndex = 7;
            this.btnPrueba.Text = "Prueba DB";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // groupBoxInicio
            // 
            this.groupBoxInicio.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInicio.Controls.Add(this.btnLang);
            this.groupBoxInicio.Controls.Add(this.labelInicio);
            this.groupBoxInicio.Controls.Add(this.btnEnter);
            this.groupBoxInicio.Controls.Add(this.btnExit);
            this.groupBoxInicio.Controls.Add(this.textBoxUser);
            this.groupBoxInicio.Controls.Add(this.textBoxPsw);
            this.groupBoxInicio.Location = new System.Drawing.Point(540, 93);
            this.groupBoxInicio.Name = "groupBoxInicio";
            this.groupBoxInicio.Size = new System.Drawing.Size(291, 412);
            this.groupBoxInicio.TabIndex = 8;
            this.groupBoxInicio.TabStop = false;
            // 
            // P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::capaGUI.Properties.Resources.LogoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBoxInicio);
            this.Controls.Add(this.btnPrueba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.groupBoxInicio.ResumeLayout(false);
            this.groupBoxInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.GroupBox groupBoxInicio;
    }
}

