using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conta
{
    public class Cliente
    {
        public String TipoDePessoa { get; set; }
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public String DataDeNascimento { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public String Cep { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public Contas Numero { get; set; }

        public override string ToString()
        {
            return "Conta tipo: " + TipoDePessoa
                + "\nNome do Titular: " + Nome
                + "\nData de Nascimento: " + DataDeNascimento
                + "\nCPF: " + Cpf
                + "\nSexo: " + Sexo
                + "\nCEP: " + Cep
                + "\nEndereço: " + Endereco + ", " + Cidade + "-" + Estado
                + "\nTelefone: " + Telefone
                + "\nEmail: " + Email
                + "\nDados da conta\nTipo de Conta: " + Numero.TipoDeConta
                + "\nAgencia: " + Numero.Agencia + ", Conta: " + Numero.Conta
                + "\nData de Criação: " + Numero.DataDeCriacaoConta
                + "\nSaldo: " + Numero.Saldo;
              
        }
        
        
        }
    }

