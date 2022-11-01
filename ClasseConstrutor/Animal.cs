using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConstrutor
{
    internal class Animal
    {
        public string raca;
        public string cor;
        public string peso;
        public string especie;
        private int codigo;
 
        public Animal(string r, string c, string p, string e)
        {
            raca = r;
            cor = c;
            peso = p;
            especie = e;

            codigo = 101;
            Console.WriteLine("Estou no construtor");
            Console.WriteLine("Código do animal: "+codigo);
        }

        public int getCodigo()
        {
            return codigo;
        }
    }
}
