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
            var x = int.Parse(Console.ReadLine());

            Console.Write("Provide n number: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateMathematicalExpression(x, n));
            Console.WriteLine(CalculateMathematicalExpressionRecursion(x, n));
            Console.ReadKey();
        }

        private static int CalculateMathematicalExpression(int x, int n)
        {
            var result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += x + i;
            }
            return result;
        }

        private static int CalculateMathematicalExpressionRecursion(int x, int n)
        {
            if (n == 1) return x + 1;
            return (x + n--) + CalculateMathematicalExpressionRecursion(x, n);
        }
    }
}
