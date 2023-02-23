using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            r1.DefinirMedidias(4, 5);

            Console.WriteLine(r1.ObterArea()); 
        }
    }
}

//Pessoa p1 = new Pessoa("André", 21);
//p1.Apresentar();

//string path = @"C:\Windows\Temp\myfolder\file1.txt";

//Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
//Console.WriteLine("PathSeparator: " + Path.PathSeparator);
//Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
//Console.WriteLine("GetFileName: " + Path.GetFileName(path));
//Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
//Console.WriteLine("GetExtension: " + Path.GetExtension(path));
//Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
//Console.WriteLine("GetTempPath: " + Path.GetTempPath());

//    string path = @"C:\Windows\Temp\myfolder";

//    try{

//        IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//        Console.WriteLine("Folders: ");
//        foreach (string s in folders)
//        {
//            Console.WriteLine(s);
//        }

//        IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//        Console.WriteLine("Files: ");
//        foreach (string s in files)
//        {
//            Console.WriteLine(s);
//        }

//        Directory.CreateDirectory(path + @"\newfolder");
//    }
//    catch(IOException e)
//    {
//        Console.WriteLine("An error occurred");
//        Console.WriteLine(e.Message);
//    }
//}

//    string path = @"C:\Windows\Temp\file1.txt";
//    string targetPath = @"C:\Windows\temp\file2.txt";

//    try
//        {
//        string[] lines = File.ReadAllLines(path);
//        using (StreamWriter sw = File.AppendText(targetPath))
//        {
//            foreach(string line in lines)
//            {
//                sw.WriteLine(line.ToUpper());
//            }
//        }
//    }
//    catch(IOException e)
//    {
//        Console.WriteLine("An error occurred");
//        Console.WriteLine(e.Message);
//    }
//}

//static void Main(string[] args)
//{
//    string path = @"C:\Windows\Temp\file1.txt";

//    try
//    {
//        using (StreamReader sr = File.OpenText(path))
//        {
//            while (!sr.EndOfStream)
//            {
//                string line = sr.ReadLine();
//                Console.WriteLine(line);
//            }
//        }
//    }
//    catch (IOException e)
//    {
//        Console.WriteLine("An error occurred");
//        Console.WriteLine(e.Message);
//    }
//}

//string path = @"C:\Windows\Temp\file1.txt";
//FileStream fs = null;
//StreamReader sr = null;

//try{
//    fs = new FileStream(path, FileMode.Open);
//    sr = new StreamReader(fs);
//    string line = sr.ReadLine();
//    Console.WriteLine(line);
//}
//catch(IOException e)
//{
//    Console.WriteLine("An errorr ocurred");
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    if (sr != null) sr.Close();
//    if (fs != null) fs.Close();
//}

//string sourcePath = @"c:\Windows\Temp\file1.txt";
//string targetPath = @"c:\Windows\Temp\file2.txt";

//try
//{
//    FileInfo fileInfo = new FileInfo(sourcePath);
//    fileInfo.CopyTo(targetPath);
//    string[] lines = File.ReadAllLines(sourcePath);
//    foreach (string line in lines)
//    {
//        Console.WriteLine(line);
//    }
//}
//catch (IOException e)
//{
//    Console.WriteLine("An Error Occurred");
//    Console.WriteLine(e.Message);
//}

//FileStream fs = null;
//try
//{
//    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
//    StreamReader sr = new StreamReader(fs);
//    string line = sr.ReadLine();
//    Console.WriteLine(line);
//}
//catch (FileNotFoundException e)
//{
//    Console.WriteLine(e);
//}
//finally
//{
//    if(fs != null)
//    {
//        fs.Close();
//    }
//}

//try
//{
//    int n1 = int.Parse(Console.ReadLine());
//    int n2 = int.Parse(Console.ReadLine());

//    int result = n1 / n2;

//    Console.WriteLine(result);
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Division by zero is not allowed");
//}
//catch(FormatException e)
//{
//    Console.WriteLine("Format Error!: " + e.Message);
//}

//List<Account> list = new List<Account>();

//list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
//list.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
//list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
//list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

//double sum = 0.0;

//foreach(Account acc in list)
//{
//    sum += acc.Balance;
//}

//Console.WriteLine("Total Balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

//foreach(Account acc in list)
//{
//    acc.Withdraw(10.0);
//}

//foreach(Account acc in list)
//{
//    Console.WriteLine("Updated balance for account"
//        + acc.Number
//        + ": "
//        + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
//}


//Account acc = new Account(1001, "Alex", 0.0);
//BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

////UPCASTING

//Account acc1 = bacc;
//Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

////DOWNCASTING

//BusinessAccount acc4 = (BusinessAccount)acc2;
//acc4.Loan(100);

////BusinessAccount acc5 = (BusinessAccount)acc3;

//if(acc3 is BusinessAccount)
//{
//    //BusinessAccount acc5 = (BusinessAccount)acc3;
//    BusinessAccount acc5 = acc3 as BusinessAccount;
//    acc5.Loan(200.0);
//    Console.WriteLine("Loan!");
//}

//if(acc3 is SavingsAccount)
//{
//    //SavingsAccount acc5 = (SavingsAccount)acc3;
//    SavingsAccount acc5 = acc3 as SavingsAccount;
//    acc5.updateBalance();
//    Console.WriteLine("Update");
//}

//BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);
//Console.WriteLine(account.Balance);

//account.Deposit(100);

//Order order = new Order
//{
//    Id = 1080,
//    Moment = DateTime.Now,
//    Status = OrderStatus.PendingPayment
//};

//Console.WriteLine(order);


//string txt = OrderStatus.PendingPayment.ToString();
//OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

//Console.WriteLine(os);
//Console.WriteLine(txt);

//DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

//DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

//DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

//Console.WriteLine("d1: " + d1);
//Console.WriteLine("d1 kind: " + d1.Kind);
//Console.WriteLine("d1 to local: " + d1.ToLocalTime());
//Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d2: " + d2);
//Console.WriteLine("d2 kind: " + d2.Kind);
//Console.WriteLine("d2 to local: " + d2.ToLocalTime());
//Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d3: " + d3);
//Console.WriteLine("d3 kind: " + d3.Kind);
//Console.WriteLine("d3 to local: " + d3.ToLocalTime());
//Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());

//Console.WriteLine();
//Console.WriteLine();

//DateTime d3 = new DateTimeNow();
//DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
//DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

//Console.WriteLine("d1: " + d1);
//Console.WriteLine("d1 Kind: " + d1.Kind);
//Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
//Console.WriteLine("d1 to Local: " + d1.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d2: " + d2);
//Console.WriteLine("d2 Kind: " + d2.Kind);
//Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
//Console.WriteLine("d2 to Local: " + d2.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //CUIDADO!
//Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

//TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

//Console.WriteLine(t);
//Console.WriteLine("Days: " + t.Days);
//Console.WriteLine("Hours: " + t.Hours);
//Console.WriteLine("Minutes: " + t.Minutes);
//Console.WriteLine("Milliseconds: " + t.Milliseconds);
//Console.WriteLine("Seconds: " + t.Seconds);
//Console.WriteLine("Ticks: " + t.Ticks);

//Console.WriteLine("Total Days: " + t.TotalDays);
//Console.WriteLine("Total Hours: " + t.TotalHours);
//Console.WriteLine("Total Minutes: " + t.TotalMinutes);
//Console.WriteLine("Total Seconds: " + t.Seconds);
//Console.WriteLine("Total Milliseconds: " + t.Milliseconds);

//TimeSpan t1 = TimeSpan.MaxValue;
//TimeSpan t2 = TimeSpan.MinValue;
//TimeSpan t3 = TimeSpan.Zero;

//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);

//TimeSpan t1 = new TimeSpan(1, 30, 10);
//TimeSpan t2 = new TimeSpan(0, 10, 5);

//TimeSpan sum = t1.Add(t2);
//TimeSpan dif = t1.Subtract(t2);
//TimeSpan mult = t2.Multiply(2.0);
//TimeSpan div = t2.Divide(2.0);

//Console.WriteLine(sum);
//Console.WriteLine(dif);
//Console.WriteLine(mult);
//Console.WriteLine(div);

//DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 215);
//string s1 = d.ToLongDateString();
//string s2 = d.ToLongTimeString();
//string s3 = d.ToShortDateString();
//string s4 = d.ToShortTimeString();
//string s5 = d.ToString();
//string s6 = d.ToString("yyy-MM-dd HH:mm:ss");
//string s7 = d.ToString("yyy-MM-dd HH:mm:ss.fff");
//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);
//Console.WriteLine(s4);
//Console.WriteLine(s5);
//Console.WriteLine(s6);
//Console.WriteLine(s7);

//Console.WriteLine(d);
//Console.WriteLine("1) Date: " + d.Date);
//Console.WriteLine("2) Day " + d.Day);
//Console.WriteLine("3) DayOfWeek " + d.DayOfWeek);
//Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
//Console.WriteLine("5) Hour: " + d.Hour);
//Console.WriteLine("6) Kind " + d.Kind);
//Console.WriteLine("7) Millisecond: " + d.Millisecond);
//Console.WriteLine("8) Minute: " + d.Minute);
//Console.WriteLine("9) Month: " + d.Month);
//Console.WriteLine("10) Second: " + d.Second);
//Console.WriteLine("11) Ticks: " + d.Ticks);
//Console.WriteLine("12) TimeOfDay " + d.TimeOfDay);
//Console.WriteLine("13) Year " + d.Year);

//DateTime dd = new DateTime(2001, 8, 15, 13, 45, 58, 215);
//DateTime d2 = dd.AddHours(2);
//DateTime d3 = dd.AddMinutes(3);
//DateTime d4 = dd.AddDays(7);
//Console.WriteLine(dd);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);

//DateTime sub1 = new DateTime(2000, 10, 15);
//DateTime sub2 = new DateTime(2000, 10, 18);

//TimeSpan t = sub2.Subtract(sub1);

//Console.WriteLine(t);


//TimeSpan t1 = new TimeSpan();
//TimeSpan t2 = new TimeSpan(900000000L);
//TimeSpan t3 = new TimeSpan(2, 11, 21);
//TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
//TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);
//Console.WriteLine(t4);
//Console.WriteLine(t5);

//TimeSpan timeFromDays = TimeSpan.FromDays(1.5);
//TimeSpan timeFromHours = TimeSpan.FromHours(1.5);
//TimeSpan timeFromMinutes = TimeSpan.FromMinutes(1.5);
//TimeSpan timeFromSeconds = TimeSpan.FromSeconds(1.5);
//TimeSpan timeFromMillieseconds = TimeSpan.FromMilliseconds(1.5);
//TimeSpan timeFromTicks = TimeSpan.FromTicks(900000000L);
//Console.WriteLine(timeFromDays);
//Console.WriteLine(timeFromHours);
//Console.WriteLine(timeFromMinutes);
//Console.WriteLine(timeFromSeconds);
//Console.WriteLine(timeFromMillieseconds);
//Console.WriteLine(timeFromTicks);

//DateTime dataexact = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
//Console.WriteLine(dataexact);
//DateTime dataexact2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
//Console.WriteLine(dataexact2);

//DateTime data = DateTime.Parse("2000-08-15");
//Console.WriteLine(data);
//DateTime data2 = DateTime.Parse("2000-08-15 13:05:58");
//Console.WriteLine(data2);
//DateTime data3 = DateTime.Parse("15/08/2000");
//Console.WriteLine(data3);
//DateTime data4 = DateTime.Parse("15/08/2000 13:05:58");
//Console.WriteLine(data4);

//DateTime d1 = DateTime.Now;
//Console.WriteLine(d1);
//Console.WriteLine(d1.Ticks);
//DateTime d2 = new DateTime(2021, 10, 15);
//DateTime d3 = new DateTime(2021, 10, 15, 20, 45, 3);
//DateTime d4 = new DateTime(2021, 10, 15, 20, 45, 3, 500);
//DateTime d5 = DateTime.Now;
//DateTime d6 = DateTime.Today;
//DateTime d7 = DateTime.UtcNow;

//Console.WriteLine(d2); 
//Console.WriteLine(d3);
//Console.WriteLine(d4);
//Console.WriteLine(d5);
//Console.WriteLine(d6);
//Console.WriteLine(d7);


//string original = "abcde FGHIJ ABC abc DEFG   ";

//string s1 = original.ToUpper();
//string s2 = original.ToLower();
//string s3 = original.Trim();

//int n1 = original.IndexOf("bc");
//int n2 = original.LastIndexOf("bc");

//string s4 = original.Substring(3);
//string s5 = original.Substring(3, 5);
//string s6 = original.Replace('a', 'x');
//string s7 = original.Replace("abc", "xy");

//bool b1 = String.IsNullOrEmpty(original);
//bool b2 = String.IsNullOrWhiteSpace(original);

//Console.WriteLine("Original -" + original + "-");
//Console.WriteLine("ToUpper -" + s1 + "-");
//Console.WriteLine("ToLower -" + s2 + "-");
//Console.WriteLine("Trim -" + s3 + "-");
//Console.WriteLine("IndexOf('bc') -" + n1);
//Console.WriteLine("LastIndexOf('bc') -" + n2);
//Console.WriteLine("Substring(3): -" + s4);
//Console.WriteLine("Substring(3, 5): -" + s5);
//Console.WriteLine("Replace ('a', 'x'): -" + s6);
//Console.WriteLine("Replace ('abc', 'xy'): -" + s7);

//Console.WriteLine("IsNullOrEmpty: "+ b1);
//Console.WriteLine("IsNullOrWhiteSpace: " + b2);

//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

//Console.WriteLine(desconto);

//int x = int.Parse(Console.ReadLine());

//switch(x) {
//    case 1:
//        Console.WriteLine(x + " Domingo");
//        break;
//    case 2:
//        Console.WriteLine(x + " Segunda");
//        break;
//    case 3:
//        Console.WriteLine(x + " Terça");
//        break;
//    case 4:
//        Console.WriteLine(x + " Quarta");
//        break;
//    case 5:
//        Console.WriteLine(x + " Quinta");
//        break;
//    case 6:
//        Console.WriteLine(x + " Sexta");
//        break;
//    case 7:
//        Console.WriteLine(x + " Sábado");
//        break;
//    default:
//        Console.WriteLine(x + " Invalid Value");
//        break;
//}

//var x = 10;
//var y = 20.0;
//var z = "Maria";

//Console.WriteLine(x +" "+ y +" "+ z);

//            int N = int.Parse(Console.ReadLine());
//            int negativos = 0;

//            int[,] mat = new int[N,N];

//            for (int i = 0; i < N; i++) {

//                string[] values = Console.ReadLine().Split(' ');
//                for (int j = 0; j < N; j++) {
//                    mat[i, j] = int.Parse(values[j]);
//                    if (mat[i,j] < 0) {
//                        negativos++;
//                    }
//                }
//            }

//            Console.WriteLine("Main Diagonal: ");

//            for (int i = 0; i < N; i++) {
//                Console.Write(mat[i,i] + " ");
//            }
//            Console.WriteLine("\nNegative numbers: " + negativos);

//double[,] mat = new double[2, 3];

//Console.WriteLine(mat.Length);

//Console.WriteLine(mat.Rank);

//Console.WriteLine(mat.GetLength(0));

//Console.WriteLine(mat.GetLength(1));

//List<string> list = new List<string>();

//list.Add("Maria");
//list.Add("Bob");
//list.Add("Ana");
//list.Add("Amanda");
//list.Insert(2, "Marcos");

//foreach (string l in list) {
//    Console.WriteLine(l);
//}

//Console.WriteLine("List Count: " + list.Count);
//string s1 = list.Find(x => x[0] == 'A');
//Console.WriteLine("First 'A': " + s1);

//string s2 = list.Last(x => x[0] == 'A');
//Console.WriteLine("Last 'A': " + s2);

//int pos1 = list.FindIndex(x => x[0] == 'A');
//Console.WriteLine("First position " + pos1);

//int pos2 = list.FindLastIndex(x => x[0] == 'A');
//Console.WriteLine("Last position " + pos2);

//List<string> list2 = list.FindAll(x => x.Length == 5);

//Console.WriteLine("------------------------------");

//foreach(string obj in list2) {
//    Console.WriteLine(obj);
//}

//Console.WriteLine("------------------------------");


//list.RemoveAt(3);
//list.Remove("Ana");

//foreach (string obj in list) {
//    Console.WriteLine(obj);
//}

//list.RemoveAll(x => x[0] == 'M');

//Console.WriteLine("----------------------------------");
//foreach (string obj in list) {
//    Console.WriteLine(obj);
//}

//list.RemoveRange(0, 2);

//Console.WriteLine("----------------------------------");
//foreach (string obj in list) {
//    Console.WriteLine(obj);
//}


//string[] vect = new string[] { "Maria", "Bob", "Alex" };

//for (int i = 0; i < vect.Length; i++) {
//    Console.WriteLine(vect[i]);
//}

//Console.WriteLine("------------------------");

//foreach (string v in vect) {
//    Console.WriteLine(v);
//}

//int a = 10;
//Calculator2.Triple(ref a);
//Console.WriteLine(a);

//int b = 10;
//int triple;
//Calculator2.Triple2(b, out triple);
//Console.WriteLine(triple);

//int s1 = Calculator2.Sum(1, 20, 30, 10, 50);
//Console.WriteLine(s1);
//Console.WriteLine(Calculator2.Sum(10, 9, 10, 90, 20, 100, 10, 2, 09, 3, 4, 5));


//int n = int.Parse(Console.ReadLine());
//double media = 0;
//ProdutoComVetor[] Produto = new ProdutoComVetor[n];
//for (int i = 0; i < Produto.Length; i++) {
//    string nome = Console.ReadLine();
//    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    Produto[i] = new ProdutoComVetor { Name = nome, Price = price };

//    media += Produto[i].Price;
//}
//media = media / Produto.Length;
//Console.WriteLine("AVARANGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
//int n = int.Parse(Console.ReadLine());
//double media = 0;
//double[] vect = new double[n];
//for (int i = 0; i < vect.Length; i++) {
//    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    media+=vect[i];
//}
//media = media / vect.Length;
//Console.WriteLine("AVERANGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));


//double? x = null;
//double? y = 10.0;

//Console.WriteLine(x.GetValueOrDefault());
//Console.WriteLine(y.GetValueOrDefault());

//Console.WriteLine(x.HasValue);
//Console.WriteLine(y.HasValue);

//if (x.HasValue)
//Console.WriteLine(x.Value); //erro (precisa ter um valor)
//else
//    Console.WriteLine("X is Null");
//if (y.HasValue)
//Console.WriteLine(y.Value);
//else
//    Console.WriteLine("y is Null");

//double? x = null;
//double? y = 10;

//double a = x ?? 5;
//double b = y ?? 5;

//Console.WriteLine(a + " " + b);

//Point p;
//p.X = 10;
//p.Y = 20;
//Console.WriteLine(p);
//p = new Point();
//Console.WriteLine(p);

//Produto p = new Produto("TV", 500.00, 10);
//p.Nome = "TV 4K";
//Console.WriteLine(p.Nome);
//p.Nome = "T";
//Console.WriteLine(p.Nome);
//Console.WriteLine(p.Preco);
//Console.WriteLine(p.Quantidade);

//Console.WriteLine("Entre os dados do produto:");
//Console.Write("Nome: ");
//string nome = Console.ReadLine();
//Console.Write("Preço: ");
//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
////Console.Write("Quantidade no estoque: ");
////int quantidade = int.Parse(Console.ReadLine());

//Produto p2 = new Produto();

//Produto p3 = new Produto()
//{ Nome = "TV",
//    preco = 500.0,
//    quantidade = 0 };

//Console.WriteLine();
//Console.WriteLine("Dados do produto: " + p2);
//Console.WriteLine();
//Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
//int qte = int.Parse(Console.ReadLine());
//p2.AdicionarProdutos(qte);
//Console.WriteLine();
//Console.WriteLine("Dados atualizados: " + p2);
//Console.WriteLine();
//Console.Write("Digite o número de produtos a ser removido do estoque: ");
//qte = int.Parse(Console.ReadLine());
//p2..RemoverProdutos(qte);
//Console.WriteLine();
//Console.WriteLine("Dados atualizados: " + p2);

//    Console.WriteLine("Entre o Valor do raio: ");
//    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    double circ = Calculadora.Circunferencia(raio);

//    Console.WriteLine("Cincunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

//    double volume = Calculadora.Volume(raio);

//    Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//    Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

//}

//Produto p = new Produto();

//Console.WriteLine("Entre os dados do produto: ");
//Console.Write("Nome: ");
//p.Nome = Console.ReadLine();
//Console.Write("Preço: ");
//p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.Write("Quantidade no estoque: ");
//p.quantidade = int.Parse(Console.ReadLine());

//Console.WriteLine("Dados do Produto: " + p);

//Console.Write("\nDigite o número de produtos a ser adicionado: ");
//int qte = int.Parse(Console.ReadLine());
//p.AdicionarProdutos(qte);
//Console.WriteLine("Dados Atualizados: " + p);

//Console.Write("\nDigite o número de produtos a ser Removidos: ");
//qte = int.Parse(Console.ReadLine());
//p.RemoverProdutos(qte);
//Console.WriteLine("Dados Atualizados: " + p);

//    Triangulo x, y;

//    x = new Triangulo();
//    y = new Triangulo();

//    Console.WriteLine("Entre com as Medidas do Triângulo X: ");

//    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    Console.WriteLine("Entre com as Medidas do Triângulo Y: ");

//    y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    double areaX = x.Area();
//    double areaY = y.Area();

//    Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//    Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//    if (areaX > areaY)
//        Console.WriteLine("Maior área: X");
//    else
//        Console.WriteLine("Maior área Y");
//}


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