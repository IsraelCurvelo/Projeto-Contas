using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public class Conta
    {
        public String tipoDeConta;
        public String agencia;
        public String conta;
        public String dataDeCriacaoConta;
        public double saldo { get; private set; }
        public String senha;



        public String toString( Conta nova)
        {
            return "\nTipo de conta: " + tipoDeConta
                + "\nAg: " + agencia+"    "
                + "  Cc: "   + conta
                + "\nData de Criação: " + dataDeCriacaoConta;                
                
                
                 }

        public void sacar(double saldo)
        {
            if (saldo <= this.saldo) {
                this.saldo -= saldo;
                MessageBox.Show("Saque Autorizado!");
                    } else
            {
                MessageBox.Show("Saldo Insuficiente!");

            }
        }

        public void depositar (double valor)
        {
            this.saldo += valor;
            MessageBox.Show("Depósito Realizado com sucesso!");

        }

    }
}
