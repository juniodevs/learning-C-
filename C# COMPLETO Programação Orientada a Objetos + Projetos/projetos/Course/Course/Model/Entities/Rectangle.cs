using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area(){
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle Color = "
                + Color
                + ", Width"
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", Área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
