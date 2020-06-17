using System;
using System.Collections.Generic;
using System.Linq;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość  
             * największej z nich.
             */
            var numbersCollection = new List<double>();

            Console.WriteLine("Which one is bigger?");
            Console.Write("Provide first value: ");
            numbersCollection.Add(double.Parse(Console.ReadLine()));
            Console.Write("Provide second value: ");
            numbersCollection.Add(double.Parse(Console.ReadLine()));
            Console.Write("Provide third value: ");
            numbersCollection.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine($"And the biggest number is: {GetBiggestNumber(numbersCollection)}");
            Console.WriteLine($"And the biggest number is: {GetBiggestNumberAlternative(numbersCollection)}");
            Console.ReadKey();
        }

        private static double GetBiggestNumber(List<double> numbersCollection)
        {
            var biggestNumber = numbersCollection[0];

            foreach (var number in numbersCollection)
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            return biggestNumber;
        }

        private static double GetBiggestNumberAlternative(IEnumerable<double> numbersCollection)
        {
            return numbersCollection.OrderByDescending(number => number).ToList()[0];
        }
    }
}
