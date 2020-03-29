using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class ClientePessoaJuridica : Cliente
    {
        public int Cnpj { get; set; }
    }
}
