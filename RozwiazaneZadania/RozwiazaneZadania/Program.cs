using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę. 
             * Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
             * int oraz liczbę całkowitą (mnożnik). 
             * Wykonaj zadanie w dwóch wariantach:
             * a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona
             * przez metodę.
             * b)  Wyniki  mnożenia  elementów  tablicy mają  zostać umieszczone  w  tablicy będącej
             * argumentem metody(wtym wariancie metoda ma niczego nie zwracać).
             * Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien
             * wyświetlić tablicę {2,8,12,16,4}.
             */

            var table = new int[5] { 1, 4, 6, 8, 2 };
            var multiplier = 3;

            Console.WriteLine("a)");
            PrintaTable(MultiplyResultsToNewTable(table, multiplier));
            Console.WriteLine("b)");
            MultiplyResultsNoNewTable(ref table, multiplier);
            PrintaTable(table);

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

        private static void MultiplyResultsNoNewTable(ref int[] table, int multiplier)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = table[i] * multiplier;
            }
        }

        private static void PrintaTable(int[] table)
        {
            foreach (var item in table)
            {
                Console.Write("{0, 3}", item);
            }
            Console.WriteLine();
        }
    }
}
