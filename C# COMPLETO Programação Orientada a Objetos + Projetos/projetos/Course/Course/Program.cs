using System;
using System.Globalization;
namespace Course
{
    internal class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8; 
            //OU
            double n5 = (double)10 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            
            //float x = 4.5f;
            //double y = x;
            //Console.WriteLine(y);

            //double a = 5.1;
            //float b;
            //b = (float)a;
            //Console.WriteLine(b);

            //int c = (int)a;
            //Console.WriteLine(c);

            //int d = 5;
            //int e = 2;

            //double resultado = (double)d / e;

            //Console.WriteLine(resultado);

            //int a = 10;
            //Console.WriteLine(a);
            //a += 2;
            //Console.WriteLine(a);
            //a *= 3;
            //Console.WriteLine(a);
            //string s = "ABC";
            //Console.WriteLine(s);
            //s += "DEF";
            //Console.WriteLine(s);
            //a++;
            //Console.WriteLine(a);
            //a--;
            //Console.WriteLine(a);
            //int b = ++a;
            //Console.WriteLine(b);

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;
            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            //Console.WriteLine($"{produto2}, cujo preco é ${preco2.ToString("F2")}");
            //Console.WriteLine($"\nRegistro: {idade}, codigo {codigo}, e gênero: {genero}\n");
            //Console.WriteLine($"Medida com oito casa decimais: {medida.ToString("F8")}");
            //Console.WriteLine($"Arredondando (três casa decimais): {medida.ToString("F3")}");
            //Console.WriteLine($"Separado por deciam ivariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} rais", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F4")} reais");

            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais");

            //Console.Write("Bom Dia!");
            //Console.WriteLine("Boa Tarde!");
            //Console.WriteLine("Boa Noite!");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            //SByte x = 100;
            //Console.WriteLine(x);
            //byte n1 = 126;
            //Console.WriteLine(n1);
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648L;
            //float n5 = 4.5f;
            //double n6 = 4.5;
            //string nome = "Carlos";
            //char genero = 'F';
            //bool completo = false;
            //char letra = '\u0041';
            //object obj1 = "Alex Brown";
            //object obj2 = 4.5f;
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(completo); 
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            //int num = int.MinValue;
            //int num2 = int.MaxValue;
            //sbyte num3 = sbyte.MinValue;
            //decimal num4 = decimal.MaxValue;
            //Console.WriteLine(num);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
        }
    }
}