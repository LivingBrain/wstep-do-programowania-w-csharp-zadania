using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz statyczną metodę, która oblicza wyrażenie: 
             * W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main()wywołaj funkcję dla xi n
             * (liczb naturalnych) wczytanych z klawiatury.
             */

            Console.Write("Provide x number: ");
            var xNumber = int.Parse(Console.ReadLine());

            Console.Write("Provide n number: ");
            var nNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateMathematicalExpression(xNumber, nNumber));
            Console.WriteLine(CalculateMathematicalExpressionRecursion(xNumber, nNumber));
            Console.ReadKey();
        }

        private static int CalculateMathematicalExpression(int xNumber, int nNumber)
        {
            var results = 0;
            for (int i = 1; i <= nNumber; i++)
            {
                results += xNumber + i;
            }
            return results;
        }

        private static int CalculateMathematicalExpressionRecursion(int xNumber, int nNumber)
        {
            if (nNumber == 1) return xNumber + 1;
            return (xNumber + nNumber--) + CalculateMathematicalExpressionRecursion(xNumber, nNumber);
        }
    }
}
