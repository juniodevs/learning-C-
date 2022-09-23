/*
 * Fazer um programa que leia três valores com ponto flutuante de
 * dupla precisão: A, B e C. Em seguida, calcule e 
 * mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B.
*/

using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = Math.PI * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangualo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(" TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangualo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}