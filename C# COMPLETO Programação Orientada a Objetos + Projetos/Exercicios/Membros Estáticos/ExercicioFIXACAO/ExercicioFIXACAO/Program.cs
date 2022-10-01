using ExercicioFIXACAO;
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

        Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}