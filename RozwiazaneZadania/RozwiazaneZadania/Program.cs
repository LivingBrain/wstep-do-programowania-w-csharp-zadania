using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dana  jest n-elementowa  tablica  liczb  całkowitych tab1.  Napisz  program  kopiujący 
             * wartości elementów tablicy tab1do tablicy tab2(o tym samym rozmiarze) z przesunięciem o 
             * jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w 
             * tablicy  docelowej  pod  indeksem  1,  element  o  indeksie 1 ma być w tablicy docelowej pod 
             * indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o  indeksie  0 w  tablicy
             * docelowej.
             */

            Random random = new Random();

            Console.WriteLine("Copy table and move values by one position.");
            int[] table = new int[10];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(1, 99);
            }

            Console.WriteLine($"Generated table values: ");
            PrintaTable(table);
            Console.WriteLine($"Copied table values: ");
            PrintaTable(CopyTable(table));


            Console.ReadKey();
        }

        public static int[] CopyTable(int[] table)
        {
            int[] secondTable = new int[table.Length];

            secondTable[0] = table[table.Length - 1];
            Array.Copy(table, 0, secondTable, 1, table.Length - 1);

            return secondTable;
        }


        private static void PrintaTable(int[] table)
        {
            foreach (var item in table)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
