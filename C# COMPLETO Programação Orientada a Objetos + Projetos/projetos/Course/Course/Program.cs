using System;

namespace Course
{
    internal class Program {
        static void Main(string[] args) {
            SByte x = 100;
            Console.WriteLine(x);
            byte n1 = 126;
            Console.WriteLine(n1);
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Carlos";
            char genero = 'F';
            bool completo = false;
            char letra = '\u0041';
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(completo); 
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int num = int.MinValue;
            int num2 = int.MaxValue;
            sbyte num3 = sbyte.MinValue;
            decimal num4 = decimal.MaxValue;
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
}