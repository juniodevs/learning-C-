using ExercicioProposto221.Entities;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Studant> set = new HashSet<Studant>();

            Console.Write("How Many students for courrse A? ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                set.Add(new Studant(ID));
            }

            Console.Write("How Many students for courrse B? ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                set.Add(new Studant(ID));
            }

            Console.Write("How Many students for courrse C? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int ID = int.Parse(Console.ReadLine());
                set.Add(new Studant(ID));
            }

            Console.WriteLine("Total Students: " + set.Count);

        }
    }
}