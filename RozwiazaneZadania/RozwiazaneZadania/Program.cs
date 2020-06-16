using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
             * miesiąci wyświetli jego nazwę słownie.
             */

            Console.Write("Write date like DD-MM-RRRR: ");
            Console.WriteLine($"Month: {DateTime.Parse(Console.ReadLine()).ToString("MMMM")}");
            Console.ReadKey();
        }        
    }
}
