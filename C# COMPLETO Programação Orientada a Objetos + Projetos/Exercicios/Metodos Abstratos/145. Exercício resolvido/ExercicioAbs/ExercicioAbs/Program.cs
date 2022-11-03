using ExercicioAbs.Entities;
using ExercicioAbs.Entities.Enums;
using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of Shapes: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Retangle or Ciircle (r/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (c == 'r')
                {
                    Console.Write("Widht: ");
                    double Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    Console.Write("Height: ");
                    double Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    shapes.Add(new Rectangle(Width, Height, color));
                }
                if (c == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}