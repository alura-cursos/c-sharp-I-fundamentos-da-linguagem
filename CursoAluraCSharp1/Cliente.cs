using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco; 
        public int idade;

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
