
namespace Central_autobuses
{
    partial class PaginaPrincipal
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
            this.BtnComprarBoleto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPasajeros = new System.Windows.Forms.Button();
            this.PanelMenus = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnComprarBoleto
            // 
            this.BtnComprarBoleto.Location = new System.Drawing.Point(117, 11);
            this.BtnComprarBoleto.Name = "BtnComprarBoleto";
            this.BtnComprarBoleto.Size = new System.Drawing.Size(235, 68);
            this.BtnComprarBoleto.TabIndex = 0;
            this.BtnComprarBoleto.Text = "Comprar boleto";
            this.BtnComprarBoleto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnPasajeros);
            this.panel1.Controls.Add(this.BtnComprarBoleto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 91);
            this.panel1.TabIndex = 1;
            // 
            // BtnPasajeros
            // 
            this.BtnPasajeros.Location = new System.Drawing.Point(447, 11);
            this.BtnPasajeros.Name = "BtnPasajeros";
            this.BtnPasajeros.Size = new System.Drawing.Size(235, 68);
            this.BtnPasajeros.TabIndex = 1;
            this.BtnPasajeros.Text = "Ver pasajeros";
            this.BtnPasajeros.UseVisualStyleBackColor = true;
            // 
            // PanelMenus
            // 
            this.PanelMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenus.Location = new System.Drawing.Point(0, 0);
            this.PanelMenus.Name = "PanelMenus";
            this.PanelMenus.Size = new System.Drawing.Size(800, 359);
            this.PanelMenus.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMenus);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PaginaPrincipal";
            this.Text = "Central | Pagina Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnComprarBoleto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPasajeros;
        private System.Windows.Forms.Panel PanelMenus;
    }
}

