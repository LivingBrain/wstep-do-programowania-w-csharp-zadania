using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
             * wyłącznie wartości dodatnie.Obie tablice mają być jednowymiarowe o rozmiarze równym 10
             * (czyli  10-elemetowe).  Elementy  pierwszej  tablicy  (tab1) należy wpisać w trakcie deklaracji  
             * tej tablicy.
             */

            Console.WriteLine("Comy positive numbers to table 2.");
            var firstTable = new int[10];
            var secondTable = new int[10];
            
            for (int i = 0; i < firstTable.Length; i++)
            {
                Console.Write($"Provide number for table element no {i+1}: ");
                firstTable[i] = int.Parse(Console.ReadLine());
            }
            PrintaTable(CopyPositiveNumbersToSecondTable(firstTable, secondTable));

            Console.ReadKey();
        }

        private static int[] CopyPositiveNumbersToSecondTable(int[] firstTable, int[] secondTable)
        {
            var tableIndex = 0;
            foreach (var element in firstTable)
            {
                if (element > 0) secondTable[tableIndex++] = element;
            }
            return secondTable;
        }

        private static void PrintaTable(int[] table)
        {
            Console.WriteLine("Table begin.");
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Table end.");
        }
    }
}
