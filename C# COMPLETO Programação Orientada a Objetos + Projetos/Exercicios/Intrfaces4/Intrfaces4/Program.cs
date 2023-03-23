using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int contractNumber = int.Parse(Console.ReadLine());

                Console.Write("Date (dd/MM/yyyy): ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Contract value: ");
                double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter number of installments: ");
                int numberOfInstallments = int.Parse(Console.ReadLine());

                Contract myContract = new Contract(contractNumber, contractDate, contractValue);

                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(myContract, numberOfInstallments);

                Console.WriteLine("Installments:");
                foreach (Installment installment in myContract.Installments)
                {
                    Console.WriteLine(installment);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Invalid input. " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
