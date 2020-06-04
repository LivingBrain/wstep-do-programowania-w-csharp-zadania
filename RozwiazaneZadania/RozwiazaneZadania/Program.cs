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
             * Liczba Njest doskonała,gdy jest równa sumie swych podzielników mniejszych od niej 
             * samej np. 6=1+2+3=6 –jest liczbą doskonałą. Napisz program znajdujący liczby doskonałe w
             * przedziale <1,n>, gdzie npodaje użytkownik.
             */

            Console.WriteLine("Find perfect numbers in <1,n>.");
            Console.Write("Provide natural number n: ");
            var userNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Perfect numbers:");
            PrintSetOfPerfectNumbers(userNumber);
            Console.ReadKey();
        }       
        

        private static void PrintSetOfPerfectNumbers(int maxNumber)
        {
            var counter = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                if (CheckIfPerfectNumber(i))
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No perfect numbers in this set.");
            }
        }

        private static bool CheckIfPerfectNumber(int number)
        {
            int divisorsSum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisorsSum += i;
                }
            }

            // alternative solution
            // divisorsSum = Enumerable.Range(1, number - 1).Where(x => number % x == 0).Sum();

            return divisorsSum == number ? true : false;
        }
    }
}
