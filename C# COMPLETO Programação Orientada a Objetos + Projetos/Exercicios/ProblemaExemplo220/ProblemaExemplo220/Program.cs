using System;
using ProblemaExemplo220.Entities;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter File full path: ");
            string path = @"C:\Windows\Temp\in.txt";
            Console.WriteLine(path);
            

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instante = DateTime.Parse(line[1]);

                        set.Add(new LogRecord(name, instante));
                    }
                    Console.Write("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }



            


        }
    }
}