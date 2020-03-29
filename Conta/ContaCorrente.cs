using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public  class ContaCorrente : Contas , ITributos

    {
        public double TaxaManutencao { get; set; }

        public void CalcularTributos()
        {
            double prov = this.Saldo;
           MessageBox.Show("O valor a pagar de imposto é de: R$ "+ (prov * 0.05));
            
        }

        public override bool Sacar(double valor)
        {
            valor += 0.10;            
            return Sacar(valor);
        }

        public void Transferir (double valor, Contas destino)
        {
                     
            bool conf = this.Sacar(valor+1.5);
            if (conf == true)
            {
                destino.Depositar(valor);
                
            }
            else
            {
                MessageBox.Show( "Tranferência não efetuada!");
            }

        }
    }
}
