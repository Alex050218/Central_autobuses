
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.BtnComprarBoleto.Click += new System.EventHandler(this.MostrarForm);
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
            this.BtnPasajeros.Click += new System.EventHandler(this.MostrarForm);
            // 
            // PanelMenus
            // 
            this.PanelMenus.Controls.Add(this.label3);
            this.PanelMenus.Controls.Add(this.pictureBox1);
            this.PanelMenus.Controls.Add(this.label2);
            this.PanelMenus.Controls.Add(this.label1);
            this.PanelMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenus.Location = new System.Drawing.Point(0, 0);
            this.PanelMenus.Name = "PanelMenus";
            this.PanelMenus.Size = new System.Drawing.Size(800, 359);
            this.PanelMenus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Que haremos hoy?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Central_autobuses.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(207, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione una de las opciones de abajo";
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
            this.PanelMenus.ResumeLayout(false);
            this.PanelMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnComprarBoleto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPasajeros;
        private System.Windows.Forms.Panel PanelMenus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

