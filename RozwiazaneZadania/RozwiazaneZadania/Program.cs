using System;
using System.Collections.Generic;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program  analizujący  częstość  występowania  poszczególnych  znaków  w
             * łańcuchu  znaków  wprowadzonym  przez  użytkownika.Np.   dla   wprowadzonego   tekstu
             * „abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.
             */

            Console.Write("Write something: ");
            var someText = Console.ReadLine();

            Console.WriteLine($"Your text has: {CountLetters(someText)}");
            Console.ReadKey();
        }        

        private static string CountLetters(string someText)
        {
            var lettersCounter = "";
            var duplicateList = new List<string>();
            for (int i = 0; i < someText.Length; i++)
            {
                if (!duplicateList.Contains(someText[i].ToString()))
                {
                    duplicateList.Add(someText[i].ToString());
                    var counter = 0;

                    for (int j = 0; j < someText.Length; j++)
                    {
                        if (someText[i] == someText[j]) counter++;
                    }

                    lettersCounter += $"{someText[i]} - {counter}, ";
                }
            }

            return lettersCounter;
        }

    }
}
