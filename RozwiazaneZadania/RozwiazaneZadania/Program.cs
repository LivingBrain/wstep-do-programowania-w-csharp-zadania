using System;
using System.Collections.Generic;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program,  który  dla  zadeklarowanej  niżej  zmiennej  łańcuchowej  wyświetli  jej
             * zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
             * // fragment powieści A. A.Milne, "KubuśPuchatek"
             * string tekst = "W parę godzin później, gdy noc zbierała siędo odejścia,\n" +
             * "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
             * "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
             * "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
             * "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
             */

            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

            var textRows = tekst.Split(new string[] {"\n"}, StringSplitOptions.None);

            Console.WriteLine(tekst);
            Console.WriteLine($"How many rows: {textRows.Length}");

            for (int i = 0; i < textRows.Length; i++)
            {
                Console.WriteLine($"Row number {i + 1} has {textRows[i].Length} chars and without spaces {GetTextCharsWithoutSpaces(textRows[i])}.");
            }

            Console.ReadKey();
        }     

        private static int GetTextCharsWithoutSpaces(string text)
        {
            var textWithoutSpaces = text.Contains(" ") ? text.Replace(" ", "") : text;

            return textWithoutSpaces.Length;
        }
    }
}
