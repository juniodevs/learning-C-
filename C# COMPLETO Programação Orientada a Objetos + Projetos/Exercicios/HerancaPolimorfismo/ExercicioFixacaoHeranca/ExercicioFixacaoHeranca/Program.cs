using ExercicioFixacaoHeranca.Entities;
using System;
using System.Globalization;
using System.Security.AccessControl;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) : ");
                    DateTime manufacturedate = Convert.ToDateTime(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufacturedate));
                }
                else if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsfee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}