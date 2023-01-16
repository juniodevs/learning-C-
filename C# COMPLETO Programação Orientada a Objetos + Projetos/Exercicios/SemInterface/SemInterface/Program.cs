using SemInterface.Entities;
using SemInterface.Services;
using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data ");
            Console.Write("Car Model: ");
            string Model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter Price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter Price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRetal = new CarRental(start, finish, new Vehicle(Model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.PrrocessInvoice(carRetal);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRetal.Invoice);
        }
    }
}