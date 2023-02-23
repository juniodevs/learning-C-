using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine("Oi eu sou " + Nome + " Tenho " + Idade + " Anos de Idade");
        }
    }
}
