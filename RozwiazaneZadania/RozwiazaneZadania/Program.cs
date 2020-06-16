using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy 
             * należy umieścićw tablicach dwuwymiarowych w trakcie deklaracji. Program ma wyświetlić
             * macierz  wynikową.  Wskazówka:  Dodawanie  macierzy –macierz  wynikowa C zawiera 
             * elementy,  które stanowią sumę elementów macierzy A  i  B o  odpowiednich  indeksach,  tzn.
             * element  w  zerowym  wierszu  i  zerowej  kolumnie  macierzy  A  jest  dodawany  do  elementu  o
             * tych samych indeksach macierzy B, element A [0,1]do B [0,1]...itd.
             */

            var random = new Random();
            var xDimension = 2;
            var yDimension = 3;

            var firstMatrix = GenerateMatrix(random, xDimension, yDimension);
            var secondMatrix = GenerateMatrix(random, xDimension, yDimension);

            Console.WriteLine("First matrix");
            PrintaTwoDimensionTable(firstMatrix);
            Console.WriteLine("Second matrix");
            PrintaTwoDimensionTable(secondMatrix);
            Console.WriteLine();
            Console.WriteLine("Sum of two matrices");
            PrintaTwoDimensionTable(AddTwoMatrixs(firstMatrix, secondMatrix));

            Console.ReadKey();
        }

        public static int[,] AddTwoMatrixs(int[,] firstMatrix, int[,] secondMatrix)
        {
            var thirdMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
            for (int i = 0; i < thirdMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < thirdMatrix.GetLength(1); j++)
                {
                    thirdMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return thirdMatrix;
        }

        private static int[,] GenerateMatrix(Random random, int xDimension, int yDimension)
        {
            var table = new int[xDimension, yDimension];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = random.Next(1, 100);
                }
            }

            return table;
        }

        private static void PrintaTwoDimensionTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
