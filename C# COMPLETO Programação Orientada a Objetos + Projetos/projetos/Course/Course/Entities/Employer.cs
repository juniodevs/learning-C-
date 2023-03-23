using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Employer : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employer (string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Employer))
            {
                throw new ArgumentException("Comparing error: arrgument is not employeer");
            }

            Employer other = obj as Employer;
            return Name.CompareTo(other.Name);
        }
    }
}
