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
            this.groupBoxPedidos = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxPedidos
            // 
            this.groupBoxPedidos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPedidos.Location = new System.Drawing.Point(493, 12);
            this.groupBoxPedidos.Name = "groupBoxPedidos";
            this.groupBoxPedidos.Size = new System.Drawing.Size(395, 576);
            this.groupBoxPedidos.TabIndex = 1;
            this.groupBoxPedidos.TabStop = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::claseGUI.Properties.Resources.LogoDelizia;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBoxPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPedidos;
    }
}