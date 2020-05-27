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
             * int x = 100;
             * Console.WriteLine(++x * 2);
             */

            var x = 100;
            var y = 100;

            Console.WriteLine("Increment operator");
            Console.WriteLine("int x = 100;");
            Console.WriteLine("Console.WriteLine(++x * 2);");
            Console.WriteLine(++x * 2);
            Console.WriteLine("int y = 100;");
            Console.WriteLine("Console.WriteLine(y++ * 2);");
            Console.WriteLine(y++ * 2);
            Console.ReadKey();
        }
    }
}
