using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public abstract class Contas
    {
        public String TipoDeConta { get; set; }
        public String Agencia { get; set; }
        public String Conta { get; set; }
        public DateTime DataDeCriacaoConta { get; set; }
        public double Saldo { get; protected set; }
        public String Senha { get; private set; }



        public virtual bool Sacar(double saldo)
        {
            if (saldo <= this.Saldo)
            {
                this.Saldo -= saldo;
                MessageBox.Show("Transação Autorizada, efetuando o débito na conta!");
                return true;
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
                return false;
            }
        }

        public virtual void Depositar(double valor)
        {
            this.Saldo += valor;
            MessageBox.Show("Transação Realizada com sucesso!\nEfetuando o crédito na conta");

        }

        public void AlterarSenha(String novaSenha)
        {
            if (novaSenha.Length >= 4)
            {
                this.Senha = novaSenha;
                MessageBox.Show("Senha cadastrada com Sucesso!");
            }
            
        }
    }
}
