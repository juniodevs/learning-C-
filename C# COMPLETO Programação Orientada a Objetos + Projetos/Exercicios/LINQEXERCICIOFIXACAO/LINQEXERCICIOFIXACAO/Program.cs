using LINQEXERCICIOFIXACAO.Entities;
using System;
using System.Linq;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            string path = @"C:\Windows\Temp\in.txt";

            using StreamReader sr = File.OpenText(path);
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(',');
                    string name = lines[0];
                    string email = lines[1];
                    double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }

                Console.Write("Enter salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Email of people whose salary is more than: " + salario.ToString("F2", CultureInfo.InvariantCulture));

                var more = employees.Where(s => s.Salary > salario).OrderBy(n => n.Name);

                foreach (Employee emp in more)
                {
                    Console.WriteLine(emp.Email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': ");
                var somas = employees.Where(em => em.Name[0] == 'M').Sum(em => em.Salary);

                Console.WriteLine(somas);


                    
            }
        }
    }
}