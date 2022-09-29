using System.Security.Cryptography.X509Certificates;

namespace Exercicio06 {
    internal class Aluno {
        public string Nome;
        public double nota1 = 0;
        public double nota2 = 0;
        public double nota3 = 0;

        public void getterNotas() {
            double NotaFinal = 0;
            bool repetir = true;

            while (repetir) {
                Console.WriteLine("Digite a Nota 1");
                double nota1 = double.Parse(Console.ReadLine());
                if (nota1 > 30 && nota1 < 0)
                    Console.WriteLine("Nota 1 pode ser no máximo 30");
                else
                    repetir = false; 
            }

            NotaFinal += nota1;
            repetir = true;


            while (repetir) {
                    Console.WriteLine("Digite a Nota 2");
                    double nota2 = double.Parse(Console.ReadLine());
                if (nota2 > 35 && nota2 < 0)
                    Console.WriteLine("Nota 2 pode ser no máximo 35 e maior que 0");
                else
                    repetir = false;
                }

            NotaFinal += nota2;
            repetir = true;

            while (repetir) {
                    Console.WriteLine("Digite a Nota 3");
                    double nota3 = double.Parse(Console.ReadLine());
                if (nota3 > 35 && nota3 < 0)
                    Console.WriteLine("Nota 3 pode ser no máximo 35 e maior que 0");
                else
                    repetir = false;
                }

                NotaFinal += nota3;
                repetir = true;
                double i = NotaFinal;
                double QuantoFalta = 0;

                Console.WriteLine("NOTA FINAL = "
                    + NotaFinal);
                do {
                    if (NotaFinal >= 60) {
                        Console.WriteLine("Aprovado");
                        break;
                    }
                    else {
                        QuantoFalta++;
                        i++;
                    }
                }
                while (i < 60);

                if (QuantoFalta > 0) {
                    Console.WriteLine("FALTARAM "
                        + QuantoFalta +" PONTOS");
                }

            }
        }
    }
