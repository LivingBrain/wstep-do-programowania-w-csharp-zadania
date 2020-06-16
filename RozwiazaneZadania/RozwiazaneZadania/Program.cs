using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program,  który deklaruje  i  inicjalizuje  dwuwymiarową  tablicę liczb
             * rzeczywistych o  rozmiarze 5 x 5. Program  ma  wyświetlić  elementy  tablicy  (wiersz  po 
             * wierszu),  a  następnie wyświetlić  sumę elementów  znajdujących  się  na  głównej  przekątnej 
             * tablicy(główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n)
             */

            Random random = new Random();

            Console.WriteLine("Two dimension table.");
            var table = new int[5, 5];


            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = random.Next(1, 99);
                }
            }

            Console.WriteLine($"Generated table values: ");
            PrintaTwoDimensionTable(table);
            Console.WriteLine($"Calculated sum: {SumValues(table)}");

            Console.ReadKey();
        }

        public static int SumValues(int[,] table)
        {
            int sum = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                sum += table[i, i];
            }

            return sum;
        }


        private static void PrintaTwoDimensionTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    } else
                    {
                        Console.ResetColor();
                    }
                    Console.Write("{0, 4}", table[i, j]);

                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
