/*
Fazer um programa para ler o código de uma peça 1,
o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor
unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            int codigoDaPeca = int.Parse(vet[0]);
            int numeroDePecas = int.Parse(vet[1]);
            double valorDaPeca = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            int codigoDaPeca2 = int.Parse(vet2[0]);
            int numeroDePecas2 = int.Parse(vet2[1]);
            double valorDaPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorFinal = (numeroDePecas * valorDaPeca) + (numeroDePecas2 * valorDaPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}