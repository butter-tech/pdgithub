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

            Console.WriteLine("3. Feladat: Lista elemeinek kiírása");
            PrintNumbers();

            Console.WriteLine("4. Feladat: Minimum kiválasztása és kiírása");
            int minimum = FindMinimum();
            Console.WriteLine($"A lista legkisebb eleme: {minimum}");

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

        private static void PrintNumbers()
        {
            Console.WriteLine($"Lista elemei: {string.Join(", ", numbers)}");
        }

        private static int FindMinimum()
        {
            if (numbers.Count == 0)
            {
                return 0; // Vagy más érték, ha nincs minimum, itt most 0-t adunk vissza
            }

            int minimum = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            return minimum;
        }

    }
}
