/*
 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
 * sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração
 * mínima de 1 hora e máxima de 24 horas.
*/

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            int horainicio = int.Parse(vet[0]);
            int horariofinal = int.Parse(vet[1]);

            int duracao;
            if (horainicio < horariofinal) {
                duracao = horariofinal - horainicio;
            }
            else {
                duracao = 24 - horainicio + horariofinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");


        }
    }
}
