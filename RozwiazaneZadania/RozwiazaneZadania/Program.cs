using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma 
             * prosić  użytkownika  o  podanie  współczynników  równania,  a  następnie  ma  wyświetlić 
             * stosowny komunikat. 
             */


            Console.Write("Provide number a (bigger than zero): ");
            var aNumber = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Provide number b: ");
            var bNumber = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Provide number c: ");
            var cNumber = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            var calculatedDelta = DeltaCalculator(aNumber, bNumber, cNumber);
            Console.WriteLine($"Calculated delta: {calculatedDelta}");
            if (calculatedDelta > 0)
            {
                Console.WriteLine($"Results: {ZeroPlaces(calculatedDelta, aNumber, bNumber)}");
            }
            else
            {
                Console.WriteLine("Delta is less than zero so no zero places.");
            }

            Console.ReadKey();
        }

        private static double DeltaCalculator(double aNumber, double bNumber, double cNumber)
        {
            var calculatedDelta = Math.Pow(bNumber, 2) - 4 * aNumber * cNumber;
            return calculatedDelta;
        }

        private static string ZeroPlaces(double delta, double aNumber, double bNumber)
        {
            var xOne = (-bNumber - Math.Sqrt(delta)) / (2 * aNumber);

            var xTwo = (-bNumber + Math.Sqrt(delta)) / (2 * aNumber);

            return $"x1: {xOne} and x2: {xTwo}";
        }
    }
}
