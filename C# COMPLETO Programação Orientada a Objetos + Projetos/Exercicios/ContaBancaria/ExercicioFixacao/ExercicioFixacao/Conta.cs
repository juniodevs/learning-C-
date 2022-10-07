
using System.Globalization;

namespace ExercicioFixacao {
    class Conta {
        private int _numConta = 0;
        private string _titularDaConta;
        private double _saldo = 0;

        public Conta(int numeroConta, string nome) {
            this._numConta = numeroConta;
            this._titularDaConta = nome;
        }

        public void depositoInicial() {
            Console.Write("Haverá depósito inicial (s/n)? ");
            char verificacao = char.Parse(Console.ReadLine());
            if (verificacao == 's' || verificacao == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                _saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        public void deposito() {

            Console.Write("Entre o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            _saldo += deposito;

            dadosDaConta();
        }

        public void saque() {

            Console.Write("Entre o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            _saldo -= (saque + 5);

            dadosDaConta();
        }

        public void dadosDaConta(){
            Console.WriteLine("Dados da conta:\nConta "
                + _numConta
                + ", Titular: "
                + _titularDaConta
                + ", Saldo: R$" + _saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }

    }
}
