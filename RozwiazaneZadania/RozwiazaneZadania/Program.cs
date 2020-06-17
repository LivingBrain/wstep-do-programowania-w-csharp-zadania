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
             * Napisz program,  który  szyfruje  podany  przez  użytkownika  tekst  prostym  szyfrem 
             * podstawieniowym zwanym  „gaderypoluki”.  Nazwa  pochodzi  od  jednego  z  najczęściej
             * używanych kluczy GA-DE-RY-PO-LU-KI. Klucz ten zawiera pary znakowych zamienników
             * umieszczonych między  myślnikami.  Litery,  których  nie  ma  w  kluczu  pozostawia  się  w 
             * szyfrowanym tekście bez zmian. Przykładowo tekst „DRZEWO” po zaszyfrowaniu ma postać
             * „EYZDWP”.
             */

            var cipherKey = "GA-DE-RY-PO-LU-KI";
            var alternativeCipherKey = "GADERYPOLUKI";
            var originalText = "Litery, których nie ma w kluczu tekście bez zmian";
            var cipheredText = "Iulcz tdn zgwkdyg ogyr zngipwrch zgmkdnnkiów";

            Console.WriteLine($"Original text: {originalText}");
            Console.WriteLine($"Ciphered text: {CipherDecipher(originalText, cipherKey)}");
            Console.WriteLine();
            Console.WriteLine($"Original ciphered text: {cipheredText}");
            Console.WriteLine($"Deciphered text: {CipherDecipher(cipheredText, cipherKey)}");
            Console.WriteLine();
            Console.WriteLine("*** Alternative solution ***");
            Console.WriteLine($"Original text: {originalText}");
            Console.WriteLine($"Ciphered text: {AlternativeCipherDecipher(originalText, alternativeCipherKey)}");
            Console.WriteLine();
            Console.WriteLine($"Original ciphered text: {cipheredText}");
            Console.WriteLine($"Deciphered text: {AlternativeCipherDecipher(cipheredText, alternativeCipherKey)}");

            Console.ReadKey();
        }        

        private static string CipherDecipher(string originalText, string cipherKey)
        {
            var convertedText = "";
            var text = originalText.ToLower();
            var cipherKeySplitList = cipherKey.ToLower().Split('-');

            for (int i = 0; i < text.Length; i++)
            {
                var newChar = "";
                for (int j = 0; j < cipherKeySplitList.Length; j++)
                {
                    if (cipherKeySplitList[j].Contains(text[i]))
                    {
                        newChar = cipherKeySplitList[j].Replace(text[i].ToString(), "");
                        break;
                    } 
                }

                if (string.IsNullOrEmpty(newChar))
                {
                    convertedText += Char.IsUpper(originalText[i]) ? text[i].ToString().ToUpper() : text[i].ToString(); 
                }
                else
                {
                    convertedText += Char.IsUpper(originalText[i]) ? newChar.ToUpper() : newChar; ;
                }
            }

            return convertedText;
        }

        private static string AlternativeCipherDecipher(string originalText, string cipherKey)
        {
            var convertedText = "";
            var text = originalText.ToLower();
            var cipherKeyLower = cipherKey.ToLower();

            foreach (var textChar in text)
            {
                var charIndexInKey = cipherKeyLower.IndexOf(textChar);

                if (charIndexInKey % 2 == 0)
                {
                    convertedText += cipherKeyLower[charIndexInKey + 1];
                }
                else if (charIndexInKey == -1)
                {
                    convertedText += textChar;
                }
                else 
                {
                    convertedText += cipherKeyLower[charIndexInKey - 1];
                }
            }

            return convertedText;
        }

    }
}
