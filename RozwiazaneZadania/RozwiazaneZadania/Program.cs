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


            // one coin combination
            foreach (var coin in allCoins)
            {
                var coinsCombinationList = new List<int>();
                for (int i = 1; i <= totalSum / coin; i++)
                {
                    coinsCombinationList.Add(coin);
                }

                PrintCoinsList(coinsCombinationList);
            }

            var coinPairsList = new List<int>();
            // two coins combination
            foreach (var coin in allCoins)
            {
                foreach (var secondCoin in allCoins)
                {
                    if (coin != secondCoin && !coinPairsList.Contains(coin + secondCoin))
                    {
                        coinPairsList.Add(coin + secondCoin);

                        var firstCoinCollectionList = new List<int>();
                        for (int i = 1; i < totalSum; i++)
                        {
                            var secondCoinCollectionList = new List<int>();
                            firstCoinCollectionList.Add(coin);
                            for (int j = 1; j <= totalSum - firstCoinCollectionList.Sum(); j++)
                            {
                                secondCoinCollectionList.Add(secondCoin);
                                if (firstCoinCollectionList.Sum() + secondCoinCollectionList.Sum() == totalSum)
                                {
                                    PrintCoinsList(firstCoinCollectionList.Concat(secondCoinCollectionList).OrderByDescending(n => n).ToList());
                                    break;
                                }
                                else if (firstCoinCollectionList.Sum() + secondCoinCollectionList.Sum() > totalSum) {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            // three coins combination
            int allCoinsSum = allCoins.Sum();

            var allCoinsSumString = new List<int>();
            foreach (var coin in allCoins)
            {
                allCoinsSumString.Add(coin);
            }

            foreach (var coin in allCoins)
            {
                if (allCoinsSum + coin > totalSum) continue;

                var coinsCollectionList = new List<int>();
                for (int i = 1; i <= totalSum - allCoinsSum; i++)
                {
                    coinsCollectionList.Add(coin);
                    if (allCoinsSum + coinsCollectionList.Sum() == totalSum) break;
                }

                PrintCoinsList(allCoinsSumString.Concat(coinsCollectionList).OrderByDescending(n => n).ToList());
            }

            Console.ReadKey();
        }           
        
        private static void PrintCoinsList(IList<int> coinsList)
        {
            for (int i = 0; i < coinsList.Count; i++)
            {
                Console.Write(coinsList[i]);
                if (i < coinsList.Count - 1)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }
    }
}
