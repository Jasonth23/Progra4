using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmInvocarWcf : Form
    {
        public frmInvocarWcf()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var elCalculo = new Interface.LogicaNegocio.EjemploCalculos();
            var elPrimerCalc = (Interface.LogicaNegocio.IEjemploCalculos)elCalculo;
            tbMensj1.Text = elPrimerCalc.show();
            
            var ElSegundo = (Interface.LogicaNegocio.IEjemploCalculosDos)elCalculo;
            tbMensj2.Text = ElSegundo.show();

        }
    }
}
