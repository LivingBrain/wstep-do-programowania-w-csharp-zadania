using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jaką wartość będzie miała zmienna x po wykonaniu poniższych instrukcji? Najpierw
             * oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
             * int x, y = 4;
             * x = (y -= 2);
             * x = y++;
             * x = y--; 
             */

            int x, y = 4;
            Console.WriteLine("int x, y = 4;");
            x = (y -= 2);
            Console.WriteLine("x = (y -= 2);");
            Console.WriteLine(x);
            Console.WriteLine($"y value = {y}");
            x = y++;
            Console.WriteLine("x = y++;");
            Console.WriteLine($"y value = {y}");
            Console.WriteLine($"x value = {x}");
            x = y--;
            Console.WriteLine("x = y--;");
            Console.WriteLine($"y value = {y}");
            Console.WriteLine($"x value = {x}");

            Console.ReadKey();
        }
    }
}
