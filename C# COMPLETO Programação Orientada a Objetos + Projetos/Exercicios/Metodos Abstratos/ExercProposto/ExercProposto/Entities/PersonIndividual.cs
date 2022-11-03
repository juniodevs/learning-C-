using System.Globalization;

namespace ExercProposto.Entities
{
    class PersonIndividual : Person
    {
        public double HealthExp { get; set; }

        public PersonIndividual(string name, double anualIncome , double healthExp) 
            : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double TaxesPaid()
        {
            double imp = 0;
            if (AnualIncome < 20000.00)
            {
                imp = 0.15;
            }
            else if (AnualIncome >= 20000.00)
            {
                imp = 0.25;
            }

            double final = 0;

            if (HealthExp == 0) {
                final = (AnualIncome * imp);
            }
            else if (HealthExp > 0)
            {
                final = ((AnualIncome * imp)) - ((HealthExp * 0.50));
            }
            return final;
        }
    }
}
