using System.Globalization;
namespace ExercicioFixacaoList {
    class Employee {
        public int? id { get; set; } = null;
        public string? name { get; set; } = null;
        public double salary { get; set; } = 0;

        public void increaseSalary(double percentage) {
            salary += salary * percentage / 100.0;
        }

        public Employee(int id, string name, double salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString() {
            return id + ", " + name + ", " + salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
