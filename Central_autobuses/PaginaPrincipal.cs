using System;
using System.Windows.Forms;

namespace Central_autobuses
{
    public partial class PaginaPrincipal : Form
    {
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
                ComprarBoleto PantallaBoleto = new ComprarBoleto
                {
                    TopLevel = false,
                    AutoScroll = false
                };

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

                PanelMenus.Controls.Add(PantallaPasajeros);
                PantallaPasajeros.Show();
            }
        }
    }
}
