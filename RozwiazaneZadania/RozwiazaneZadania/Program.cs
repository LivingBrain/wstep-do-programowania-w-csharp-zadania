using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien 
             * wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.
             */

            Console.WriteLine("Is divider?");
            Console.Write("Provide first int value: ");
            var firstValue = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Provide second int value: ");
            var secondValue = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Is second number a divider of first number?: {(CheckIfIsDivider(firstValue, secondValue) ? "Yes" : "No")}");
            Console.ReadKey();
        }

        private static bool CheckIfIsDivider(int firstValue, int secondValue)
        {
            return firstValue % secondValue == 0;
        }
    }
}
