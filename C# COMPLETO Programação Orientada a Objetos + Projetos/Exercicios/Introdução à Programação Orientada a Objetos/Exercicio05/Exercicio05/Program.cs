using Exercicio05;
using System;
using System.Globalization;
namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();


            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário "
                + funcionario.Nome
                + ", $ "
                + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            double porcentagem = double.Parse(Console.ReadLine());
            porcentagem = porcentagem * 0.01;

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: "
                + funcionario.Nome
                + ", $ "
                + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}