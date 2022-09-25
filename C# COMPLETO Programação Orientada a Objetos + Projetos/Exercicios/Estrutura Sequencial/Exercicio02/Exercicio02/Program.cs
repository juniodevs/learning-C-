/*
Faça um programa para ler o valor do raio de um círculo,
e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
*/

using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o Raio do Círculo");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = (Math.PI * Math.Pow(raio, 2));
            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}