using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public  class ContaPoupanca : Contas
    {
        public double TaxaRendimento { get; set; }


        public override void Depositar(double valor)
        {
            this.Saldo += (valor + TaxaRendimento);
        }
    }
}
