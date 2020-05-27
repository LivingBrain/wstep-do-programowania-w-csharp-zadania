using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Po wykonaniu poniższych linii programu:
             * int x = 2, y = 3;
             * x *= y * 2;
             */

            int x = 2, y = 3;
            x *= y * 2;
            
            Console.WriteLine("x *= y * 2;");
            Console.WriteLine(x);
            Console.WriteLine("x *= 3 * 2");
            Console.WriteLine("x *= 6");
            Console.WriteLine("x = x * 6");
            Console.WriteLine("x = 2 * 6");
            Console.WriteLine("x = 12");

            Console.ReadKey();
        }
    }
}
