using ExercicioLINQ.Entities;
using System;
using System.Linq;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\in.txt";
            List<Product> list = new List<Product>();

            try { 
            using StreamReader sr = File.OpenText(path);
                {
                    while(!(sr.EndOfStream))
                    {
                       string[] lines = sr.ReadLine().Split(',');
                       string name = lines[0];
                       double price = double.Parse(lines[1], CultureInfo.InvariantCulture);
                       list.Add(new Product(name, price));
                    }
                }

                var AvPrice = list.Select(p => p.Price).Average();

                Console.WriteLine("Average Price: " + AvPrice.ToString("F2", CultureInfo.InvariantCulture));

                var Order = list.Where(p => p.Price < AvPrice).OrderByDescending(p => p.Name);

                foreach (Product p in Order)
                {
                    Console.WriteLine(p.Name);
                }

                Console.WriteLine();

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}