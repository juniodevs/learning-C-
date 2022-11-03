using ExercicioAbs.Entities.Enums;
using System.ComponentModel;

namespace ExercicioAbs.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) 
            : base(color)
        {
            Height = height;
            Width = width;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
