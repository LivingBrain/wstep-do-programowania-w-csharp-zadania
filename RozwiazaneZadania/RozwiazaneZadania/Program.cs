using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program obliczający n! (nsilnia), gdzie njest podane przez użytkownika.
             */

            Console.WriteLine("Factorial.");
            Console.Write("Provide natural number n: ");
            var nNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Calculated factorial number is: {CalculateFactorialNumber(nNumber)}");
            

            Console.ReadKey();
        }

        private static int CalculateFactorialNumber(int nNumber)
        {
            return nNumber == 0 ? 1 : NFactorial(nNumber);
        }

        private static int NFactorial(int nNumber)
        {
            var calculatedFactorial = 1;
            for (int i = 1; i <= nNumber; i++)
            {
                calculatedFactorial *= i;
            }
            return calculatedFactorial;
        }
    }
}
