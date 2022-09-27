using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Course
{
    class Program {
        static void Main(string[] args) {

            double xA, xB, xC;
            double yA, yB, yC;


            Console.WriteLine("Entre com as Medidas do Triângulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as Medidas do Triângulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área Y");


        }


        //Console.Write("Digite Quantos Números inteiros você vai digitar: ");
        //int num = int.Parse(Console.ReadLine());
        //int soma = 0;
        //int resultado = 0;

        //for (int i = 1; i <= num; i++) {
        //    Console.Write("Valor : #{0} ", i);
        //    soma = int.Parse(Console.ReadLine());
        //    resultado += soma;
        //}

        //Console.WriteLine("Soma = " + resultado);



        //Console.Write("Digite um Número: ");
        //double x = double.Parse(Console.ReadLine());
        //double raiz = 0;

        //while (x >= 0) {
        //raiz = Math.Sqrt(x);
        //Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
        //Console.Write("Digite um Número: ");
        //x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //}

        //Console.WriteLine("Número Negativo");

        //Console.WriteLine("Digite 3 Números");

        //int n1 = int.Parse(Console.ReadLine());
        //int n2 = int.Parse(Console.ReadLine());
        //int n3 = int.Parse(Console.ReadLine());
        //double resultado = Maior(n1, n2, n3);
        //Console.WriteLine("Maior é " + resultado);
        //resultado = Maior(3, 5, 7);
        //Console.WriteLine("Maior é " + resultado);

        //double preco = double.Parse(Console.ReadLine());
        //double desconto = 0.0;

        //if (preco > 100.0) {
        //    desconto = preco * 0.1;
        //}
        //Console.WriteLine(desconto);
        //Console.WriteLine("Digite o Horário");
        //int horario = int.Parse(Console.ReadLine());
        //if (horario < 12) {
        //    Console.WriteLine("Bom Dia!");
        //}
        //else if (12 <= horario && horario < 18) {
        //    Console.WriteLine("Boa Tarde!");
        //}
        //else if (horario >= 18) {
        //    Console.WriteLine("Boa Noite!");
        //}
        //Console.WriteLine("Digite um Número");
        //int a = int.Parse(Console.ReadLine());
        //if(a % 2 == 0) {
        //    Console.WriteLine(a + " É um Número Par");
        //}
        //else {
        //    Console.WriteLine("É um Número Impar");
        //}
        //int x = 10;
        //Console.WriteLine("Bom Dia!");
        //if (x > 5) {
        //    Console.WriteLine("Boa Tarde!");
        //}
        //Console.WriteLine("Boa Noite!");
        //bool c1 = 2 > 3 && 4 != 5;
        //bool c2 = 2 > 3 || 4 != 5; // true
        //bool c3 = !(2 > 3) && 4 != 5; // true

        //Console.WriteLine(c1);
        //Console.WriteLine(c2);
        //Console.WriteLine(c3);

        //Console.WriteLine("-----");

        //bool c4 = 10 < 5; // false
        //bool c5 = c2 || c3 && c4;

        //Console.WriteLine(c5);

        //int a = 10;
        //bool c1 = a < 10;
        //bool c2 = a < 20;
        //bool c3 = a > 10;
        //bool c4 = a > 5;
        //Console.WriteLine(c1);
        //Console.WriteLine(c2);
        //Console.WriteLine(c3);
        //Console.WriteLine(c4);
        //Console.WriteLine("--------------");
        //bool c5 = a <= 10;
        //bool c6 = a >= 10;
        //bool c7 = a == 10;
        //bool c8 = a != 10;
        //Console.WriteLine(c5);
        //Console.WriteLine(c6);
        //Console.WriteLine(c7);
        //Console.WriteLine(c8);

        //Console.WriteLine("Entre com seu nome completo: ");
        //string nome = Console.ReadLine();
        //Console.WriteLine("Quantos quartos tem na sua casa?");
        //int quartos = int.Parse(Console.ReadLine());
        //Console.WriteLine("Entre com o preço de um produto:");
        //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");

        //string[] vet = Console.ReadLine().Split(' ');

        //string nome2 = vet[0];
        //int idade2 = int.Parse(vet[1]);
        //double altura2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

        //Console.WriteLine(nome);
        //Console.WriteLine(quartos);
        //Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
        //Console.WriteLine(nome2);
        //Console.WriteLine(idade2);
        //Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));

        //int n1 = int.Parse(Console.ReadLine());
        //char ch = char.Parse(Console.ReadLine());
        //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //string[] vet = Console.ReadLine().Split(' ');
        //string nome = vet[0];
        //char sexo = char.Parse(vet[1]);
        //int idade = int.Parse(vet[2]);
        //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        //Console.WriteLine("Você Digitou: ");
        //Console.WriteLine(n1);
        //Console.WriteLine(ch);
        //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        //Console.WriteLine(nome);
        //Console.WriteLine(sexo);
        //Console.WriteLine(altura);
        //Console.WriteLine(idade);
        //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        //string frase = Console.ReadLine();
        //string x = Console.ReadLine();
        //string y = Console.ReadLine();
        //string z = Console.ReadLine();
        //string[] vet = Console.ReadLine().Split(' ');
        //string a = vet[0];
        //string b = vet[1];
        //string c = vet[2];
        //Console.WriteLine("Você Digitou: ");
        //Console.WriteLine(frase);
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.WriteLine(z);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //int n1 = 3 + 4 * 2;
        //int n2 = (3 + 4) * 2;
        //int n3 = 17 % 3;
        //double n4 = 10.0 / 8; 
        ////OU
        //double n5 = (double)10 / 8;

        //Console.WriteLine(n1);
        //Console.WriteLine(n2);
        //Console.WriteLine(n3);
        //Console.WriteLine(n4);
        //Console.WriteLine(n5);

        //double a = 1.0, b = -3.0, c = -4.0;

        //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

        //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        //Console.WriteLine(delta);
        //Console.WriteLine(x1);
        //Console.WriteLine(x2);


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

        //static int Maior(int n1, int n2, int n3) {
        //    if (n1 > n2 && n1 > n3)
        //        return n1;
        //    else if (n2 > n3)
        //        return n2;
        //    else
        //        return n3;
        //}
    }
}