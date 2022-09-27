using Exercicio01;
using System;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Nome da Primeira pessoa");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome da Segunda pessoa");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
                Console.WriteLine(pessoa1.nome + " É mais velho(a) que " + pessoa2.nome);
            else if (pessoa2.idade > pessoa1.idade)
                Console.WriteLine(pessoa2.nome + " É mais velho(a) que " + pessoa1.nome);
            else
                Console.WriteLine("Eles tem a mesma idade");

        }
    }
}