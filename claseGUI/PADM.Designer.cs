namespace claseGUI
{
    partial class PADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PADM));
            this.btnUserMgment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnButton2 = new System.Windows.Forms.Button();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnReparto = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserMgment
            // 
            this.btnUserMgment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgment.Location = new System.Drawing.Point(6, 19);
            this.btnUserMgment.Name = "btnUserMgment";
            this.btnUserMgment.Size = new System.Drawing.Size(181, 44);
            this.btnUserMgment.TabIndex = 0;
            this.btnUserMgment.Text = "Gestión de Usuarios";
            this.btnUserMgment.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnButton2);
            this.groupBox1.Controls.Add(this.btnButton);
            this.groupBox1.Controls.Add(this.btnReparto);
            this.groupBox1.Controls.Add(this.btnCocina);
            this.groupBox1.Controls.Add(this.btnPedidos);
            this.groupBox1.Controls.Add(this.btnUserMgment);
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 576);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnButton2
            // 
            this.btnButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton2.Location = new System.Drawing.Point(6, 119);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Size = new System.Drawing.Size(181, 44);
            this.btnButton2.TabIndex = 5;
            this.btnButton2.Text = "Button";
            this.btnButton2.UseVisualStyleBackColor = true;
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.Location = new System.Drawing.Point(6, 69);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(181, 44);
            this.btnButton.TabIndex = 4;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnReparto
            // 
            this.btnReparto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparto.Location = new System.Drawing.Point(208, 119);
            this.btnReparto.Name = "btnReparto";
            this.btnReparto.Size = new System.Drawing.Size(181, 44);
            this.btnReparto.TabIndex = 3;
            this.btnReparto.Text = "Reparto";
            this.btnReparto.UseVisualStyleBackColor = true;
            // 
            // btnCocina
            // 
            this.btnCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocina.Location = new System.Drawing.Point(208, 69);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(181, 44);
            this.btnCocina.TabIndex = 2;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(208, 19);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(181, 44);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // PADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::claseGUI.Properties.Resources.LogoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PADM";
            this.Text = "PADM";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserMgment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReparto;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnButton2;
        private System.Windows.Forms.Button btnButton;
    }
}