using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Co wyświetli się na ekranie po wykonaniu poniższych instrukcji. Najpierw oblicz 
             * wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
             *  int x, y = 5;
             *  x = ++y * 2;
             *  x = y++;
             *  x = y--;
             *  Console.WriteLine(++y); 
             */

            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(y);
            Console.WriteLine(++y);

            Console.ReadKey();
        }
    }
}
