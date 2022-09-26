using System;
using System.Net.Mail;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            int senha = 0;

            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());

                if (senha == 2002)
                    Console.WriteLine("Acesso Permitido!");
                else
                    Console.WriteLine("Senha Invalida!");
            }

        }
    }
}