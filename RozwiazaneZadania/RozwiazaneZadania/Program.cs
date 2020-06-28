using System;
using System.Collections.Generic;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Wykonaj  program  znajdujący n-ty  wyraz  ciągu  Fibonacciego  według  wzoru
             * Wykonaj program w dwóch wariantach: w jednym metoda znajdująca wyraz ciągu ma
             * być rekurencyjna, a w drugim ma wykorzystać iteracyjne podejście (z użyciem pętli). 
             */

            Console.Write("Provide n number: ");
            var nNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFibonacci(nNumber));
            Console.WriteLine(CalculateFibonacciRecursion(nNumber));
            Console.ReadKey();
        }

        private static int CalculateFibonacci(int nNumber)
        {
            var tempList = new List<int>();
            for (int i = 0; i <= nNumber; i++)
            {
                if (i == 1 || i == 0)
                {
                    tempList.Add(i);
                }
                else
                {
                    tempList.Add(tempList[i - 1] + tempList[i - 2]);
                }
            }

            return tempList[nNumber];
        }

        // (0), (1), (1), (2), (3)
        // (3), (2), (1), (1), (0)

        // (F4),      (F3),      (F2),      (F1), (F0)
        // (2 + 1),   (1 + 1),   (1 + 0),   (1),  (0)
        // (F3 + F2), (F2 + F1), (F1 + F0), (1),  (0)
        private static int CalculateFibonacciRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }            

            return CalculateFibonacciRecursion(n - 1) + CalculateFibonacciRecursion(n - 2);
        }
    }
}
