using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercProposto.Entities
{
    class PersonCompany : Person
    {
        public int Employees { get; set; }

        public PersonCompany(string name, double anualIncome , int employees)
            : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            double imp = 0;

            if(Employees <= 10)
            {
                imp = 0.16;
            }
            else
            {
                imp = 0.14;
            }

            double final = (AnualIncome * imp);

            return final;
        }
    }
}
