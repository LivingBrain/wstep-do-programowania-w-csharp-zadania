using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  metodę,  która  oblicza  sumę  cyfr  liczby  naturalnej x.  W  programie  głównym
             * wywołaj funkcję dla x wczytanego z klawiatury. Przykładowo jeśli użytkownik wpisze 125, 
             * to metoda powinna zwrócić wartość 8 (1+2+5=8). 
             */

            Console.Write("Provide x number: ");
            var xNumber = Console.ReadLine();

            Console.WriteLine(CalculateNumber(xNumber));
            Console.ReadKey();
        }

        private static int CalculateNumber(string xNumber)
        {
            var result = 0;
            foreach (var number in xNumber)
            {
                result += int.Parse(number.ToString());
            }
            return result;
        }
    }
}
