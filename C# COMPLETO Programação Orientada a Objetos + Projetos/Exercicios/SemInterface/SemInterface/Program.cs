using SemInterface.Entities;
using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data ");
            Console.Write("Car Moddel: ");
            string Model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRetal = new CarRental(start, finish, new Vehicle(Model));
        }
    }
}