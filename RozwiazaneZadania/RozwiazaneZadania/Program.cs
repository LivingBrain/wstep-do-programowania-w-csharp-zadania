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
                if (i == 0)
                {
                    tempList.Add(i);
                } else if (i == 1)
                {
                    tempList.Add(i);
                } else
                {
                    tempList.Add((tempList[i-1]) + (tempList[i - 2]));
                }
            }

            return tempList[nNumber];
        }

        private static int CalculateFibonacciRecursion(int nNumber, int start = 1, int minusOne = 1, int minusTwo = 1)
        {
            //if (nNumber == start)
            //{
            //    return minusOne + minusTwo;
            //}
            //else
            //{

            //    start++;
            //}

            //return CalculateFibonacciRecursion(nNumber++, start, minusOne, minusTwo);
        }
    }
}
