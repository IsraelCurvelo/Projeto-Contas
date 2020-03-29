using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public class ContaInvestimento : Contas , ITributos
    {


        public void CalcularTributos()
        {
            double prov = this.Saldo;
            MessageBox.Show("O valor a pagar de imposto é de: R$ " + (prov * 0.02));

        }
    }
}
