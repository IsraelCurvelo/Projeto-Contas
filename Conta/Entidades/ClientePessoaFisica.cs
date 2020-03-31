using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class ClientePessoaFisica : Cliente
    {
        public int Cpf { get; set; }
        public int Rg { get; set; }
    }
}
