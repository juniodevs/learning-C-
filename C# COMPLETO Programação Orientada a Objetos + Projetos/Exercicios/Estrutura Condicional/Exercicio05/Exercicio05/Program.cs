using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');

            int produto = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double preco = 0;

            if (produto == 1)
                preco = 4.00 * quantidade;
            else if (produto == 2)
                preco = 4.50 * quantidade;
            else if (produto == 3)
                preco = 5.00 * quantidade;
            else if (produto == 4)
                preco = 2.00 * quantidade;
            else if (produto == 5)
                preco = 1.50 * quantidade;
            else
                Console.WriteLine("PRODUTO ERRADO!");

            Console.WriteLine( "Total: R$ "+ preco.ToString("F2"));

        }
    }
}