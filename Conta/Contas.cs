using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public class Contas
    {
        public String TipoDeConta { get; set; }
        public String Agencia { get; set; }
        public String Conta { get; set; }
        public DateTime DataDeCriacaoConta { get; set; }
        public double Saldo { get; private set; }
        public String Senha { get; private set; }



        public void Sacar(double saldo)
        {
            if (saldo <= this.Saldo)
            {
                this.Saldo -= saldo;
                MessageBox.Show("Saque Autorizado!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
            MessageBox.Show("Depósito Realizado com sucesso!");

        }

        public void TrocarSenha(String novaSenha)
        {
            if (novaSenha.Length >= 8)
            {
                this.Senha = novaSenha;
                MessageBox.Show("Senha alterada com Sucesso!");
            }
            else
            {
                MessageBox.Show("A senha tem que ter no mínimo 8 caracteres");
            }
        }
    }
}
