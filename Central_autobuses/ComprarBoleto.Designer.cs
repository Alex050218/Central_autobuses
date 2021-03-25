
namespace Central_autobuses
{
    partial class ComprarBoleto
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombreCompleto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CajaTipoID = new System.Windows.Forms.ComboBox();
            this.TxtNumeroID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCantidadBoletos = new System.Windows.Forms.TextBox();
            this.CajaDestinoBoleto = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtEdad);
            this.groupBox1.Controls.Add(this.TxtNombreCompleto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(69, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(118, 65);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(199, 20);
            this.TxtEdad.TabIndex = 4;
            this.TxtEdad.TextChanged += new System.EventHandler(this.ValidarNumeros);
            // 
            // TxtNombreCompleto
            // 
            this.TxtNombreCompleto.Location = new System.Drawing.Point(118, 29);
            this.TxtNombreCompleto.Name = "TxtNombreCompleto";
            this.TxtNombreCompleto.Size = new System.Drawing.Size(199, 20);
            this.TxtNombreCompleto.TabIndex = 3;
            this.TxtNombreCompleto.TextChanged += new System.EventHandler(this.ValidarNombre);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CajaTipoID);
            this.groupBox2.Controls.Add(this.TxtNumeroID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(427, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificacion";
            // 
            // CajaTipoID
            // 
            this.CajaTipoID.FormattingEnabled = true;
            this.CajaTipoID.Items.AddRange(new object[] {
            "INE",
            "Cedula Profesional",
            "Credencial de estudiante",
            "Credencial del Instituto Nacional de las Personas Adultas Mayores"});
            this.CajaTipoID.Location = new System.Drawing.Point(69, 60);
            this.CajaTipoID.Name = "CajaTipoID";
            this.CajaTipoID.Size = new System.Drawing.Size(191, 21);
            this.CajaTipoID.TabIndex = 5;
            this.CajaTipoID.SelectedIndexChanged += new System.EventHandler(this.AgregarDatosCajas);
            // 
            // TxtNumeroID
            // 
            this.TxtNumeroID.Location = new System.Drawing.Point(69, 29);
            this.TxtNumeroID.Name = "TxtNumeroID";
            this.TxtNumeroID.Size = new System.Drawing.Size(191, 20);
            this.TxtNumeroID.TabIndex = 2;
            this.TxtNumeroID.TextChanged += new System.EventHandler(this.ValidarNumeros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCantidadBoletos);
            this.groupBox3.Controls.Add(this.CajaDestinoBoleto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(69, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 104);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boleto";
            // 
            // TxtCantidadBoletos
            // 
            this.TxtCantidadBoletos.Location = new System.Drawing.Point(118, 54);
            this.TxtCantidadBoletos.Name = "TxtCantidadBoletos";
            this.TxtCantidadBoletos.Size = new System.Drawing.Size(199, 20);
            this.TxtCantidadBoletos.TabIndex = 5;
            this.TxtCantidadBoletos.TextChanged += new System.EventHandler(this.ValidarNumeros);
            // 
            // CajaDestinoBoleto
            // 
            this.CajaDestinoBoleto.FormattingEnabled = true;
            this.CajaDestinoBoleto.Items.AddRange(new object[] {
            "Mazatlan",
            "San Luis Potosi",
            "Ciudad de Mexico"});
            this.CajaDestinoBoleto.Location = new System.Drawing.Point(118, 24);
            this.CajaDestinoBoleto.Name = "CajaDestinoBoleto";
            this.CajaDestinoBoleto.Size = new System.Drawing.Size(199, 21);
            this.CajaDestinoBoleto.TabIndex = 4;
            this.CajaDestinoBoleto.SelectedIndexChanged += new System.EventHandler(this.AgregarDatosCajas);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Enabled = false;
            this.BtnRegistrar.Location = new System.Drawing.Point(496, 189);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(191, 50);
            this.BtnRegistrar.TabIndex = 7;
            this.BtnRegistrar.Text = "Comprar boleto";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.GuardarArchivo);
            // 
            // ComprarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprarBoleto";
            this.Text = "ComprarBoleto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombreCompleto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumeroID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CajaDestinoBoleto;
        private System.Windows.Forms.TextBox TxtCantidadBoletos;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ComboBox CajaTipoID;
    }
}