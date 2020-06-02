using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który oblicza deltę dla równania kwadratowego ax^2 + bx^2 + x = 0
             * Program ma prosić użytkownika o podanie współczynników równania a, b oraz c. Wzór: 
             * delta = b^2 - 4ac
             */

            Console.WriteLine("Delta calculator.");
            Console.Write("Provide value a: ");
            var aValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            Console.Write("Provide value b: ");
            var bValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            Console.Write("Provide value c: ");
            var cValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            
            Console.WriteLine($"Calculated delta: {DeltaCalculator(aValue, bValue, cValue)}");
            Console.ReadKey();
        }

        private static double DeltaCalculator(double aValue, double bValue, double cValue)
        {
            var calculatedDelta = Math.Pow(bValue, 2) - 4 * aValue * cValue;
            return calculatedDelta;
        }

        private static double StringToDecimalParseAndDotReplace(string toConvert)
        {
            var dotReplaced = toConvert.Contains(".") ? toConvert.Replace(".", ",") : toConvert;
            var convertedValue = double.Parse(dotReplaced);
            return convertedValue;
        }
    }
}
