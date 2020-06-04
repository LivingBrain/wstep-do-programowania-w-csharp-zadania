using System;
using System.Collections.Generic;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te 
             * iczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero). Wynikiem działania programu
             * ma być informacja o sumie wprowadzonych przez użytkownika liczb.
             */

            Console.WriteLine("Add number until 0.");
            int userNumber;
            int numbersSum = 0;
            do
            {
                Console.Write("Provide natural number: ");
                userNumber = int.Parse(Console.ReadLine());
                numbersSum += userNumber;
            } while (userNumber != 0);
            
            Console.WriteLine($"The sum of provided numbers is: {numbersSum}");
            
            Console.ReadKey();
        }        
    }
}
