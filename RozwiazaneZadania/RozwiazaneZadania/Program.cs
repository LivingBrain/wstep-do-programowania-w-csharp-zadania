using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który pozwoli zapełnić n–elementową tablicęjednowymiarowąliczb
             * całkowitych  wartościami  podanymi  przez  użytkownika.  Na  początku  działania  programu
             * użytkownik  podaje  liczbę  elementów  tablicy,  a  następnie  poszczególne  wartości  jej 
             * elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.
             */

            Console.WriteLine("One dimension table.");
            Console.Write("How many elements in table?: ");
            var tableElements = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var intTable = new int[tableElements];
            for (int i = 0; i < intTable.Length; i++)
            {
                Console.Write($"Provide table element no {i+1}: ");
                intTable[i] = int.Parse(Console.ReadLine());
            }
            PrintaTable(intTable);

            Console.ReadKey();
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
