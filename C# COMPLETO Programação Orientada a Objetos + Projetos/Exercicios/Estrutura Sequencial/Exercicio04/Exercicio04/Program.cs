
/*
Fazer um programa que leia o número de um funcionário,
seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir,
mostre o número e o salário do funcionário, com duas casas 
decimais
*/
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            int numeroDeFuncionarios = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHORA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioFinal = valorPorHORA * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numeroDeFuncionarios);
            Console.WriteLine("U$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));


            
        }
    }
}