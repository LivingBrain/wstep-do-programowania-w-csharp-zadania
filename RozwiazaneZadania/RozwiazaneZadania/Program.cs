using System;
using System.Collections.Generic;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program obliczający sumę szeregu W(n)=1 –2  +  3 –4  +  ...±n,  gdzie njest 
             * dowolną liczbą naturalną, którą program ma wczytać.
             */

            Console.WriteLine("Numerical sequence.");
            Console.Write("Provide natural number: ");
            var userNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Calculated value for numerical sequence is: {CalculateNumericalSequence(userNumber)}");
            
            Console.ReadKey();
        }        

        private static int CalculateNumericalSequence(int userNumber)
        {
            int calculatedSequence = 0;
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 2 == 0)
                {
                    calculatedSequence -= i;
                }
                else
                {
                    calculatedSequence += i;
                }
            }
            return calculatedSequence;
        }
    }
}
