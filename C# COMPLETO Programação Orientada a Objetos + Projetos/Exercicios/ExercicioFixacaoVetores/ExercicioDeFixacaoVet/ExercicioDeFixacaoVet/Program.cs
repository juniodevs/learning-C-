using ExercicioDeFixacaoVet;
using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("How Many rooms will be ranted?: ");
            int n = int.Parse(Console.ReadLine());
            Quartos[] Hospedagem = new Quartos[10];

            for (int i = 0; i < n; i++) {
                int j = i + 1;
                Console.Write("Rent #" + j + "\nName: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                int num = quarto;
                if (quarto > 9 || quarto < 0) {
                    Console.WriteLine("O Quarto precisa ser maior que 0 e menor que 9");
                    i--;
                }
                else { 
                    Hospedagem[num] = new Quartos { Name = nome, Email = email, Room = quarto };
                }
            }

            Console.WriteLine("Busy Rooms: ");

            for (int i = 0; i < 10; i++) {
                if (Hospedagem[i] != null) {
                    Console.WriteLine(Hospedagem[i].Room + ": " + Hospedagem[i].Name + ", " + Hospedagem[i].Email);
                }
            }
        }
    }
}