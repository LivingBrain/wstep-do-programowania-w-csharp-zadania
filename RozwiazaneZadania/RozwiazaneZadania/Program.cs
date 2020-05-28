using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok 
             * przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych 
             * przez 400).
             */

            Console.WriteLine("Leap year");
            Console.Write("Provide year value: ");
            var yearValue = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Is this leap year?: {(CheckIfLeapYear(yearValue) ? "Yes" : "No")}");
            for (var i = 1900; i <= 2050; i++)
            {
                if (CheckIfLeapYear(i))
                {
                    Console.WriteLine($"Thi is a leap year: {i}");
                }
            }

            Console.ReadKey();
        }

        private static bool CheckIfLeapYear(int yearValue)
        {
            return yearValue % 4 == 0 && !(yearValue % 100 == 0 ^ yearValue % 400 == 0);
        }
    }
}
