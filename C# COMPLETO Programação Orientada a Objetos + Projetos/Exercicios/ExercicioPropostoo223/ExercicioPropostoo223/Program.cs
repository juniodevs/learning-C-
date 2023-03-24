using System;
using System.Net;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            string path = @"C:\Windows\Temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        string candidate = line[0];
                        int votos = int.Parse(line[1]);

                        if (candidatos.ContainsKey(candidate))
                        {
                            candidatos[candidate] += votos;
                        }
                        else
                        {
                            candidatos[candidate] = votos;
                        }
                    }
                    foreach (var item in candidatos)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}