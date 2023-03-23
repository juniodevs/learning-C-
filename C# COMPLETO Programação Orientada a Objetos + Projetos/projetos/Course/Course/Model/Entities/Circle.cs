using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", Radius "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", Área "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
