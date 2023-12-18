using System;
using System.Collections.Generic;

namespace pdgithub
{
    internal class Program
    {
        private static List<int> numbers = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("1. Feladat: Initial commit");
            // A konzolos alkalmazás inicializálása

            Console.WriteLine("2. Feladat: Számok hozzáadása (0 végjelig)");
            AddNumbers();


            Console.ReadKey(); // Ez itt helyezkedik el a Main metódusban
        }

        private static void AddNumbers()
        {
            int number;
            do
            {
                Console.Write("Adjon meg egy számot (0 vége): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Hibás formátum! Csak számokat fogadunk el.");
                }
            } while (number != 0);
        }

    }
}
