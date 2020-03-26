using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

            ArrayList listaClientes = new ArrayList();
            Cliente novo = new Cliente();
            Conta nova = new Conta();

            novo.tipoDePessoa = cBoxTipoPessoa.Text;        
            novo.nome = textNome.Text;
            novo.dataDeNascimento = textDataDeNascimento.Text;
            novo.sexo = cBoxSexo.Text;
            novo.cpf = textCpf.Text;
            novo.rg = textRg.Text;
            novo.entEmissao = textEstadoEmissor.Text;
            novo.cep = textCep.Text;
            novo.endereco =textEndereco.Text;
            novo.cidade = textCidade.Text;
            novo.estado = textEstado.Text;
            novo.telefone = textTelefone.Text;
            novo.email= textEmail.Text;
            nova.tipoDeConta = cBoxTipoConta.Text;
            nova.agencia = textAgencia.Text;
            nova.conta = textConta.Text;
            nova.dataDeCriacaoConta = textDataCriacao.Text;
            if (textSenha.Text == textConfirmarSenha.Text)
            {
                nova.senha = textSenha.Text;
                
                MessageBox.Show(novo.toString(novo) + nova.toString(nova)+ "\nConfirma?");

                novo.numero = nova;
                listaClientes.Add(novo);
                ConfirmacaoCadastro a = new ConfirmacaoCadastro();
                a.Show();
                MessageBox.Show("Cadastro realizado com sucesso.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("A senha não confere!");
            }


            


            
            

        }

        private void cBoxTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTipoPessoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }
    }
}
