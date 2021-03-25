using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Central_autobuses
{
    public partial class ComprarBoleto : Form
    {
        private string DirUsarios;
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

            if (Regex.IsMatch(TextoIntrucido, @"^(([A-Z][a-z]{2,})\s?){2,}$"))
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
                DatosUsuario["Destino"] = (string)CajaActual.SelectedItem;
            }
            else
            {
                DatosUsuario["ID_Tipo"] = (string)CajaActual.SelectedItem;
            }
            ActivarBoton();
        }

        public void ValidarNumeros(object sender, EventArgs e)
        {
            TextBox CajaNumeros = (TextBox)sender;
            string NumeroIntroducido = CajaNumeros.Text;

            string Dato = CajaNumeros.Name;
            string LlaveNueva = null;

            switch (Dato)
            {
                case "TxtEdad":
                    LlaveNueva = "Edad";
                    break;

                case "TxtNumeroID":
                    LlaveNueva = "ID_Numero";
                    break;

                case "TxtCantidadBoletos":
                    LlaveNueva = "Cantidad";
                    break;
            }

            if (Regex.IsMatch(NumeroIntroducido, @"^\d{1,10}$"))
            {
                DatosUsuario[LlaveNueva] = NumeroIntroducido;
            }
            else
            {
                DatosUsuario[LlaveNueva] = null;
            }
            ActivarBoton();
        }
    }
}
