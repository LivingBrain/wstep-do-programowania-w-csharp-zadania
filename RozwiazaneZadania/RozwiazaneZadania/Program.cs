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
             * bool x;
             * int y = 1, z = 1;
             * x = (y == 1 && z++ == 1);
             */

            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);

            Console.WriteLine($"x value = {x}");
            Console.WriteLine($"y value = {y}");
            Console.WriteLine($"z value = {z}");

            Console.ReadKey();
        }
    }
}
