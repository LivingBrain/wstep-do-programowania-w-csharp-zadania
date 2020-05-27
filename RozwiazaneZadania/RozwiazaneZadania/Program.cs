using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić 
             * użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach. Wzór: 
             * BMI = masa / wzrost^2
             */

            Console.WriteLine("BMI calculator.");
            Console.Write("Provide mass value in kg: ");
            var massValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            Console.Write("Provide height value in m: ");
            var heightValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            
            Console.WriteLine($"Calculated delta: {BmiCalculator(massValue, heightValue):0.##}");
            Console.ReadKey();
        }

        private static double BmiCalculator(double massValue, double heightValue)
        {
            var calculatedBmi = massValue / Math.Pow(heightValue, 2);
            return calculatedBmi;
        }

        private static double StringToDecimalParseAndDotReplace(string toConvert)
        {
            var dotReplaced = toConvert.Contains(".") ? toConvert.Replace(".", ",") : toConvert;
            var convertedValue = double.Parse(dotReplaced);
            return convertedValue;
        }
    }
}
