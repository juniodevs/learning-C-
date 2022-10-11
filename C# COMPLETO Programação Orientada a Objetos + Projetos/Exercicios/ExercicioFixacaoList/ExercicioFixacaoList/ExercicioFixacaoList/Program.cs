using ExercicioFixacaoList;
using System;
using System.Globalization;

namespace Program
{
    internal class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("How Many Employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int j = i + 1;
                Console.WriteLine("Emplyoee " + j);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                employees.Add(new Employee(id = id, name = name, salary = salary));
            }

            Console.Write("Emter the employee id that will have salary incrase: ");
            int idtoincrease = int.Parse(Console.ReadLine());

            int verificacao = 0;

            foreach (Employee employee in employees) {
                if (idtoincrease == employee.id) {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine());
                    employee.increaseSalary(percentage);
                    verificacao++;
                }
            }

            if (verificacao == 0) {
                Console.WriteLine("This id does not exist!");
            }

            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }


        }
    }
}