using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez 
             * użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
             */

            Console.Write("Write sentence: ");
            Console.WriteLine($"Counted words: {Console.ReadLine().Split(' ').Length}");
            Console.ReadKey();
        }        
    }
}
