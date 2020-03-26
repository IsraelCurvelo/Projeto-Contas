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
        public String tipoDePessoa;
        public String nome;
        public String sexo;
        public String dataDeNascimento;
        public String cpf;
        public String rg;
        public String entEmissao;
        public String cep;
        public String endereco;
        public String cidade;
        public String estado;
        public String telefone;
        public String email;
        public Conta numero;
        
        
        
        public String toString(Cliente novo)
        {
            return "Conta tipo: " + novo.tipoDePessoa
                + "\nNome do Titular: " + nome
                + "\nData de Nascimento: " + dataDeNascimento
                + "\nCPF: " + cpf
                + "\nRG: " + rg + " " + entEmissao
                + "\nSexo: " + sexo
                + "\nCEP: " + cep
                + "\nEndereço: " + endereco + ", " + cidade + "-" + estado
                + "\nTelefone: " + telefone
                + "\nEmail: " + email;
                
        }

        
        }
    }

