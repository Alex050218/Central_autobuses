using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_autobuses
{
    public partial class ComprarBoleto : Form
    {
        private string DirUsarios = null;
        private Dictionary<string, string> DatosUsuario = new Dictionary<string, string>()
        {
            { "Nombre", null },
            { "Edad", null },
            { "ID_Numero", null },
            { "ID_Tipo", null },
            { "Destino", null },
            { "Cantidad", null }
        };

        public ComprarBoleto(string DirRegistrosPasajero)
        {
            InitializeComponent();

            DirUsarios = DirRegistrosPasajero;

            CajaDestinoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;
            CajaTipoID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ActivarBoton()
        {
            BtnRegistrar.Enabled = DatosUsuario.Values.All(x => x != null);
        }

        public void ValidarNombre(object sender, EventArgs e)
        {
            TextBox CajaNombre = (TextBox)sender;
            string TextoIntrucido = CajaNombre.Text;

            if (Regex.IsMatch(TextoIntrucido, @"(([A-Z][a-z]{2,})\s?){2,}"))
            {
                DatosUsuario["Nombre"] = TextoIntrucido;
            }
            else
            {
                DatosUsuario["Nombre"] = null;
            }
            ActivarBoton();
        }

        public void AgregarDatosCajas(object sender, EventArgs e)
        {
            ComboBox CajaActual = (ComboBox)sender;

            Regex NombreCaja = new Regex(@"(?<=Caja)(.*)(?=(ID)|(Boleto))");
            string Dato = NombreCaja.Match(CajaActual.Name).Groups[0].ToString();

            if(Dato == "Destino")
            {
                DatosUsuario["Destino"] = CajaActual.Text;
            }
            else
            {
                DatosUsuario["ID_Tipo"] = CajaActual.Text;
            }
            ActivarBoton();
        }
    }
}
