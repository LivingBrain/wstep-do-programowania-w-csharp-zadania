using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program  zawierający  metodę  statyczną  obliczającą  temperaturę  w  stopniach
             * Fahrenheita na temperaturę w stopniach Celsjusza. Metoda ma przyjmować jeden argument
             * (temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.
             */

            Console.WriteLine("Fahrenheit to Celsius calculator.");
            Console.Write("Provide Fahrenheit value: ");
            string fahrenheitValue = Console.ReadLine();
            fahrenheitValue = fahrenheitValue != null && fahrenheitValue.Contains(".") ? fahrenheitValue.Replace(".", ",") : fahrenheitValue;
            Console.WriteLine($"Celsius: {CalculateFahrenheitToCelsius(double.Parse(fahrenheitValue))}");
            Console.ReadKey();
        }

        private static double CalculateFahrenheitToCelsius(double fahrenheitValue)
        {
            return (fahrenheitValue - 32) / 1.8;
        }
    }
}
