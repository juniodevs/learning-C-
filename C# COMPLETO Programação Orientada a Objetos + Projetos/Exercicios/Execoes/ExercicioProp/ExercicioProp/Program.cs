using ExercicioProp.Entities;
using ExercicioProp.Entities.Exceptions;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, withdrawlimit, initialbalance);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(amount);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error!: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error!: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error!: " + e.Message);
            }
            

        }
    }
}