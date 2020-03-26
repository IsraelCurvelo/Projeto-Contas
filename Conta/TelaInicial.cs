using System;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

           }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCliente novo = new CadastrarCliente();
            novo.Show();
            //this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void acessarConta_Click(object sender, EventArgs e)
        {
            ConsultaConta novo = new ConsultaConta();
            novo.Show();
        }
    }
}
