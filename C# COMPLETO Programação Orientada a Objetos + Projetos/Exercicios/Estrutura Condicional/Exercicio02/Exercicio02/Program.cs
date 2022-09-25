using System;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}