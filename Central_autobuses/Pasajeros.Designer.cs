
namespace Central_autobuses
{
    partial class Pasajeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaza = new System.Windows.Forms.Label();
            this.lblLuis = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mazatlan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "San Luis Potosi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad de Mexico";
            // 
            // lblMaza
            // 
            this.lblMaza.AutoSize = true;
            this.lblMaza.Location = new System.Drawing.Point(356, 54);
            this.lblMaza.Name = "lblMaza";
            this.lblMaza.Size = new System.Drawing.Size(35, 13);
            this.lblMaza.TabIndex = 3;
            this.lblMaza.Text = "label4";
            // 
            // lblLuis
            // 
            this.lblLuis.AutoSize = true;
            this.lblLuis.Location = new System.Drawing.Point(356, 105);
            this.lblLuis.Name = "lblLuis";
            this.lblLuis.Size = new System.Drawing.Size(35, 13);
            this.lblLuis.TabIndex = 4;
            this.lblLuis.Text = "label4";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(356, 151);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(35, 13);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "label4";
            // 
            // Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblLuis);
            this.Controls.Add(this.lblMaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pasajeros";
            this.Text = "Pasajeros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaza;
        private System.Windows.Forms.Label lblLuis;
        private System.Windows.Forms.Label lblCiudad;
    }
}