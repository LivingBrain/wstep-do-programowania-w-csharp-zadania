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
             * Dysponując  monetami  1  zł,  2  zł,  5  zł  sprawdź,na  ile  różnych  sposobów  można 
             * wypłacić  10  zł.  Napisz  program,  który  wyświetli  w  oknie  konsoli  wszystkie  możliwe
             * kombinacje.
             */

            IList<int> allCoins = new List<int>() { 1, 2, 5 };
            int totalSum = 10;
            Console.WriteLine("10zl all combinations");

            string allCoinsSumString = "";
            foreach (var coin in allCoins)
            {
                allCoinsSumString += $"{coin}+";
            }

            // one coin combination
            foreach (var coin in allCoins)
            {
                for (int i = 1; i <= totalSum / coin; i++)
                {
                    Console.Write(coin);
                    if (i != totalSum / coin)
                    {
                        Console.Write("+");
                    }
                }
                Console.WriteLine();
            }

            // two coins combination


            // three coins combination
            int allCoinsSum = allCoins.Sum();

            foreach (var coin in allCoins)
            {
                if (allCoinsSum + coin <= totalSum)
                {
                    var tempCoinSum = 0;
                    var tempCoinSumString = "";
                    var combinationToPrint = allCoinsSumString;

                    for (int i = 1; i <= totalSum - allCoinsSum; i++)
                    {
                        tempCoinSum += coin;
                        tempCoinSumString += $"{coin}";

                        if (allCoinsSum + tempCoinSum == totalSum)
                        {
                            combinationToPrint += tempCoinSumString;
                        } 
                        else
                        {
                            tempCoinSumString += "+";
                        }

                    }
                    Console.WriteLine(combinationToPrint);
                }
            }

            Console.ReadKey();
        }               
    }
}
