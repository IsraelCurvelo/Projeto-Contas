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

            List<Cliente> listaClientes = new List<Cliente>();
            Cliente novo = new ClientePessoaFisica();
            Contas nova = new ContaCorrente();
            novo.TipoDePessoa = cBoxTipoPessoa.Text;
            novo.Nome = textNome.Text.ToLower();
            novo.Nome = novo.ToTitleCase(novo.Nome);

            novo.DataDeNascimento = textDataDeNascimento.Text;
            novo.Sexo = cBoxSexo.Text;
            novo.Cpf = textCpf.Text;
            novo.Rg = textRg.Text;
            novo.Cep = textCep.Text;
            novo.Endereco = textEndereco.Text;
            novo.Cidade = textCidade.Text;
            novo.Estado = textEstado.Text.ToUpper();
            novo.Telefone = textTelefone.Text;
            novo.Email = textEmail.Text;
            nova.TipoDeConta = cBoxTipoConta.Text;
            nova.Agencia = textAgencia.Text;
            nova.Conta = textConta.Text;
            nova.DataDeCriacaoConta = DateTime.Now;
            MessageBox.Show(novo.Nome+" "+ novo.Estado);
            if (textSenha.Text.Length >= 4 && textConfirmarSenha.Text.Length >= 4)
            {
                if (textSenha.Text == textConfirmarSenha.Text)
                {
                    nova.AlterarSenha(textSenha.Text);

                }
                else
                {
                    MessageBox.Show("A senha não confere!");
                }
            }




            if (novo.TipoDePessoa != "" && novo.Nome != "" && novo.DataDeNascimento != "" && novo.Sexo != ""
                    && novo.Cpf != "" && novo.Rg != "" && novo.Cep != "" && novo.Endereco != "" &&
                novo.Cidade != "" && novo.Estado != "" && novo.Telefone != "" && novo.Email != "" &&
                nova.TipoDeConta != "" && nova.Agencia != "" && nova.Conta != "" && nova.Senha != null)
            {
                novo.Numero = nova;
                listaClientes.Add(novo);
                MessageBox.Show("Cadastro realizado com sucesso.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
            }

            else
            {
                MessageBox.Show("Preencha todos os campos corretamente\nCampos não podem ficar em branco\nSenha tem que ter no mínimo 4 caracteres");
            }



        }



        private void cBoxTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTipoPessoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
