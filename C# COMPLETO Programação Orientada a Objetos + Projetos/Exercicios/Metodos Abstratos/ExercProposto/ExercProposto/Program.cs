using ExercProposto.Entities;
using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax players: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company?(i/c): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PersonIndividual(name, anual, health));
                }
                else if(c == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new PersonCompany(name, anual, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0;
            
            foreach(Person person in list)
            {
                Console.WriteLine(person.Name + ": $" + person.TaxesPaid().ToString("F2"));

                sum += person.TaxesPaid();

            }

            Console.WriteLine("TOTAL TAXES $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}