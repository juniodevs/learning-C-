using ExercicioFixacao;
using System;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();
            Conta pessoa1 = new Conta(numeroConta, nome);
            pessoa1.depositoInicial();
            pessoa1.dadosDaConta();
            pessoa1.deposito();
            pessoa1.saque();
        }
    }
}