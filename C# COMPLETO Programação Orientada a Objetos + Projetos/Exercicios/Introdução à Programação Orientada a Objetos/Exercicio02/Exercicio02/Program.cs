using Exercicio02;
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Digite o Nome do funcionário");
            funcionario1.nome = Console.ReadLine();
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do funcionário");
            funcionario2.nome = Console.ReadLine();
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
