using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który podaje,ile jest liczb pierwszych w tablicy 100 elementowejtypu 
             * int.Tablicę  należy  wypełnić  losowymi  wartościami. Wskazówka:  Poniższy  fragment
             * programu pokazuje działanie klasy Random(która zawiera generator liczb pseudolosowych) –
             * w pętli zostanie wyświetlonych100  liczbwybranych  losowo z  zakresu  1 –999(o  zakresie
             * decydują argumenty podane w wywołaniu metody Next()). 
             */

            Random random = new Random();

            Console.WriteLine("Table prime number.");
            var table = new int[100];
            
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(1, 999);
            }

            Console.WriteLine($"Number of prime numbers in table: {TablePrimeNumberCount(table)}");

            Console.ReadKey();
        }
        
        private static int TablePrimeNumberCount(int[] table)
        {
            var primeNumberCounter = 0;
            foreach (var number in table)
            {
                var divisionWithRest = 0;

                for (int i = 2; i < number; i++)
                {
                    if (number % i != 0) divisionWithRest++;
                }

                if (divisionWithRest == number - 2)
                {
                    primeNumberCounter++;
                    Console.WriteLine(number);
                }
            }

            return primeNumberCounter;
        }
    }
}
