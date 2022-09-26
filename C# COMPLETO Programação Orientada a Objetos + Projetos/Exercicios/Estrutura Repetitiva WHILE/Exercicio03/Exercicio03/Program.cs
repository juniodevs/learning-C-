using System;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            int num = 0;
            int gasolina = 0;
            int alcool = 0;
            int disel = 0;
            while (true) {
                Console.WriteLine("Digite um Número de 1 a 4");
                num = int.Parse(Console.ReadLine());

                if (num == 1)
                    alcool++;
                else if (num == 2)
                    gasolina++;
                else if (num == 3)
                    disel++;
                else if (num == 4) { 
                    Console.WriteLine("Muito Obrigado");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + disel);
                    break;
                }
                else {
                    Console.WriteLine("Código Invalido");
                }
            }
        }
    }
}