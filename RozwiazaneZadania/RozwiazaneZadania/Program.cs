using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w
             * stopniach Fahrenheita. Program ma prosić użytkownika o podanie temperatury w stopniach
             * Celsjusza. Wzór: 
             * F = 32 + (9/5)C
             */

            Console.WriteLine("Celsius to Fahrenheit calculator.");
            Console.Write("Provide Celsius value: ");
            string celsiusValue = Console.ReadLine();
            celsiusValue = celsiusValue != null && celsiusValue.Contains(".") ? celsiusValue.Replace(".", ",") : celsiusValue;
            Console.WriteLine($"Fahrenheit: {CalculateCelsiusToFahrenheit(decimal.Parse(celsiusValue ?? throw new InvalidOperationException()))}");
            Console.ReadKey();
        }

        private static decimal CalculateCelsiusToFahrenheit(decimal celsiusValue)
        {
            var calculatedFahrenheitValue = (celsiusValue * 9 / 5 ) + 32;
            return calculatedFahrenheitValue;
        }
    }
}
