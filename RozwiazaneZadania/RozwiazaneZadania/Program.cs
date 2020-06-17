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
             * W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz 
             * czterech  cyfr.  Te  cztery  cyfry  to  rok  zakupu  danego  środka  trwałego.  Przykładowe
             * identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową
             * tablicę  typu stringdla  środków  trwałych,  którą  należy  zainicjalizować  przykładowymi
             * identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałegopodać liczbę
             * lat, jakie upłynęły od jego zakupu.
             */

            var codesTable = new string[5] {
                "KOMG-2002",
                "BH-2010",
                "TE-1999",
                "USE-2018",
                "KART-1972" };


            foreach (var productCode in codesTable)
            {
                Console.WriteLine($"Product with code {productCode} is {HowOld(productCode)} years old.");
            }

            Console.ReadKey();
        }        

        private static int HowOld(string productCode)
        {
            var currentDate = int.Parse(DateTime.Now.ToString("yyyy"));
            var yearOfProductPurchase = int.Parse(productCode.Split('-')[1]);
            return currentDate - yearOfProductPurchase;
        }

    }
}
