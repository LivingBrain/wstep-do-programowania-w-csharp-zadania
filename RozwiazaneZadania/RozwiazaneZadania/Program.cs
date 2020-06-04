using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości
             * 1) należy dodać do siebie, aby suma przekroczyła wartość 100.
             */

            Console.WriteLine("Sum to 100 or any other number.");
            Console.Write("Provide natural number: ");
            var sumNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"How many natural numbers need to be sum to get more than provided number?: {HowManyNumberToGetSum(sumNumber)}");
            
            Console.ReadKey();
        }

        private static int HowManyNumberToGetSum(int sumNumber)
        {
            var calculatedSum = 0;
            for (int i = 1; i < sumNumber; i++)
            {
                calculatedSum += i;
                if (calculatedSum > sumNumber) return i;
            }
            return 0;
        }
    }
}
