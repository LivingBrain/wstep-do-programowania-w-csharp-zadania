using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy n-
             * elementowej:
             * wartość i numer pozycjinajwiększego elementu,
             * wartość i numer pozycjinajmniejszego elementu
             * średnia wartości wszystkich elementów tablicy
             * liczba dodatnich elementów tablicy.
             */

            Console.WriteLine("Table info.");
            Console.Write("How big table?: ");
            var table = new int[int.Parse(Console.ReadLine())];
            
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"Provide number for table element no {i+1}: ");
                table[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetValueAndPositionOfBiggestElementInTable(table));
            Console.WriteLine(GetValueAndPositionOfSmalestElementInTable(table));
            Console.WriteLine(GetAverageOfAllTableElements(table));
            Console.WriteLine(GetPositiveTableElementsCount(table));

            Console.ReadKey();
        }

        private static string GetValueAndPositionOfBiggestElementInTable(int[] table)
        {
            var biggestElementValue = 0;
            var biggestElementPosition = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] >= biggestElementValue)
                {
                    biggestElementValue = table[i];
                    biggestElementPosition = i + 1;
                }
            }

            return $"Table biggest number {biggestElementValue} at postion {biggestElementPosition}";
        }

        private static string GetValueAndPositionOfSmalestElementInTable(int[] table)
        {
            var smalestElementValue = 0;
            var smalestElementPosition = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] <= smalestElementValue)
                {
                    smalestElementValue = table[i];
                    smalestElementPosition = i + 1;
                }
            }

            return $"Table biggest number {smalestElementValue} at postion {smalestElementPosition}";
        }

        private static string GetAverageOfAllTableElements(int[] table)
        {
            var sum = 0;
            foreach (var element in table)
            {
                sum += element;
            }
            decimal average = (decimal)sum / table.Length;

            return $"Table elements averege is: {average}";
        }

        private static string GetPositiveTableElementsCount(int[] table)
        {
            var counter = 0;
            foreach (var element in table)
            {
                if (element > 0) counter++;
            }

            return $"Table contains {counter} positive elements.";
        }

    }
}
