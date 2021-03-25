using System;
using System.IO;
using System.Windows.Forms;

namespace Central_autobuses
{

    public partial class PaginaPrincipal : Form
    {
        private string FolderDatos
        {
            get
            {
                string Folder = @"C:\DatosCentral";

                if (!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }

                return Folder;
            }
        }

        private string ArchivoPasajeros
        {
            get
            {
                string DirUsuarios = Path.Combine(FolderDatos, "Pasajeros.txt");

                if (!File.Exists(DirUsuarios))
                {
                    FileStream archivo = File.Create(DirUsuarios);
                    archivo.Close();
                }

                return DirUsuarios;
            }
        }

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        public void MostrarForm(object sender, EventArgs e)
        {
            Button BotonPresionado = (Button)sender;
            string NombreBoton = BotonPresionado.Name;

            PanelMenus.Controls.Clear();
            if(NombreBoton == "BtnComprarBoleto")
            {
                ComprarBoleto PantallaBoleto = new ComprarBoleto(ArchivoPasajeros)
                {
                    TopLevel = false,
                    AutoScroll = false
                };

                Text = "Central | Comprar boleto";
                PanelMenus.Controls.Add(PantallaBoleto);
                PantallaBoleto.Show();
            }
            else
            {
                Pasajeros PantallaPasajeros = new Pasajeros()
                {
                    TopLevel = false,
                    AutoScroll = false
                };

                Text = "Central | Asientos disponibles";
                PanelMenus.Controls.Add(PantallaPasajeros);
                PantallaPasajeros.Show();
            }
        }
    }
}
