using Exercicio04;
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo");

            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nAREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO = "
                + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}