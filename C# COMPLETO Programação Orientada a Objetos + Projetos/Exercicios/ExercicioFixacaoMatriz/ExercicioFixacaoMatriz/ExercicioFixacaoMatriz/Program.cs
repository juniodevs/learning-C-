using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {


            Console.WriteLine("Digite o Valor de N e M");
            string[] nem = Console.ReadLine().Split(' ');
            int n = int.Parse(nem[0]);
            int m = int.Parse(nem[1]);
            int selection = 0;
            int[,] mat = new int[n, m];
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("");
            selection = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == selection) {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j>0)
                            Console.WriteLine("Left: " + mat[i,j-1]);
                        if (i>0)
                            Console.WriteLine("Up: " + mat[i-1,j]);
                        if (j<n-1)
                            Console.WriteLine("Right: " + mat[i,j +1]);
                        if (i<m-1)
                            Console.WriteLine("Down: " + mat[i+1,j]);
                    }
                }
            }

        }

    }
}