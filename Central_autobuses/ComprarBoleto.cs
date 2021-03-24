using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_autobuses
{
    public partial class ComprarBoleto : Form
    {
        private string DirUsarios = null;

        public ComprarBoleto(string DirRegistrosPasajero)
        {
            InitializeComponent();

            DirUsarios = DirRegistrosPasajero;
        }
    }
}
