using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConstrutor
{
    internal class Pessoa
    {
        public string cordocabelo;
        public string nome;
        public string cpf;
        public string email;

        public Pessoa(string cordocabelo, string nome, string cpf, string email)
        {
            this.cordocabelo = cordocabelo;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }
    }
}
