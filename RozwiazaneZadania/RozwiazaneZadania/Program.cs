using System;
using System.Collections.Generic;
using System.Linq;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program,  który  przeanalizuje  dany  łańcuch  pod  kątem  wielokrotnego
             * występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy
             * idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się
             * dzie –odpowiedział Puchatek” –program powinien wypisać raport o słowach powielonych
             * w tym tekście: idzie –2 razy, po –2 razy, się –3 razy.
             */

            var someText = "Kiedy idzie balonikiem się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, kiedy wiedziały po co się idzie – odpowiedział balonikiem Puchatek";


            Console.WriteLine(someText);
            Console.WriteLine();
            Console.WriteLine($"Your text has: {CountWords(someText)}");
            Console.ReadKey();
        }        

        private static string CountWords(string someText)
        {
            var someTextWordsList = someText.Replace(",", "").Split(' ').Select(e => e.ToLower()).ToList();
            var wordsCounter = "";
            var duplicateList = new List<string>();
            for (int i = 0; i < someTextWordsList.Count; i++)
            {
                if (!duplicateList.Contains(someTextWordsList[i]))
                {
                    duplicateList.Add(someTextWordsList[i]);
                    var counter = 0;

                    for (int j = 0; j < someTextWordsList.Count; j++)
                    {
                        if (someTextWordsList[i] == someTextWordsList[j]) counter++;
                    }

                    if (counter > 1)
                    {
                        wordsCounter += $"{someTextWordsList[i]} - {counter}, ";
                    }
                }
            }

            return wordsCounter;
        }

    }
}
