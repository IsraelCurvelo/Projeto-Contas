using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
   public abstract class Seguro : ITributos
    {



        public void CalcularTributos()
        {
            double prov = 23.50;
            MessageBox.Show("O valor a pagar de imposto é de: R$ " + prov );

        }
    }
}
