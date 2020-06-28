using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uzupełnij  program  z  zadania  5.4  (dowolny  wariant)  o  metodę przeładowaną
             * przyjmującą tablicę typu stringoraz mnożnik typu int. W tym przypadku metoda ma powielać
             * łańcuch znaków (konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o
             * elementach  {"ala",  "kot",  "dom"}  oraz  mnożniku  2  program  powinien  wyświetlić  tablicę 
             * {"alaala", "kotkot", "domdom"}.
             */

            var table = new int[5] { 1, 4, 6, 8, 2 };
            var stringTable = new string[3] { "ala", "kot", "dom" };
            var multiplier = 3;

            PrintaTable(MultiplyResultsToNewTable(table, multiplier));
            Console.WriteLine();
            PrintaTable(MultiplyResultsToNewTable(stringTable, multiplier));

            Console.ReadKey();
        }

        private static int[] MultiplyResultsToNewTable(int[] table, int multiplier)
        {
            var resultsTable = new int[table.Length];

            for (int i = 0; i < table.Length; i++)
            {
                resultsTable[i] = table[i] * multiplier;
            }

            return resultsTable;
        }

        private static string[] MultiplyResultsToNewTable(string[] table, int multiplier)
        {
            var resultsTable = new string[table.Length];

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < multiplier; j++)
                {
                    resultsTable[i] = resultsTable[i] + table[i];
                }
            }

            return resultsTable;
        }


        private static void PrintaTable<T>(T[] table)
        {
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }        
    }
}
