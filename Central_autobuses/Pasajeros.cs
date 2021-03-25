using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_autobuses
{
    public partial class Pasajeros : Form
    {
        public Pasajeros()
        {
            InitializeComponent();
            string[] Destinos = { "Mazatlan", "San Luis Potosi", "Ciudad de Mexico" };
            obtenerAsientos(Destinos);
        }


        private void obtenerAsientos(string[] Destinos)
        {
            foreach(string Destino in Destinos)
            {
                string Asientos = "40";
                if (File.Exists($@"C:\DatosCentral\Asientos_{Destino}.txt"))
                {
                    using(StreamReader Archivo = new StreamReader($@"C:\DatosCentral\Asientos_{Destino}.txt"))
                    {
                        Asientos = Archivo.ReadLine();
                    }
                }

                switch (Destino)
                {
                    case "Mazatlan":
                        lblMaza.Text = Asientos;
                        break;
                    case "San Luis Potosi":
                        lblLuis.Text = Asientos;
                        break;
                    case "Ciudad de Mexico":
                        lblCiudad.Text = Asientos;
                        break;
                }
            }
        }
    }
}
