using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  programw  czterech  wariantach  (a,  b,  c  i  d), którego efektem działania będzie
             * „figura”utworzonaze znaku gwiazdki (*)przedstawiona na danym rysunku.
             * (Liczbę wyświetlanych wierszy podaje użytkownik).
             * a)
             * *
             * **
             * ***
             * ****
             * 
             * b)
             * ****
             * ***
             * **
             * *
             * 
             * c)
             *    *
             *   **
             *  ***
             * ****
             * 
             * d)
             * ****
             * *  *
             * *  *
             * ****
             */

            Console.WriteLine("Asterisk figure.");
            Console.Write("How many lines?: ");
            var lines = int.Parse(Console.ReadLine());

            PrintAsteriskFigure(lines);

            Console.ReadKey();
        }

        private static void PrintAsteriskFigure(int lines)
        {
            Console.WriteLine("a)");
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("b)");
            for (int i = 1; i <= lines; i++)
            {
                for (int j = lines; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("c)");
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= lines - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("d)");
            for (int i = 1; i <= lines; i++)
            {
                if (i == 1 || i == lines)
                {
                    for (int j = 1; j <= lines; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= lines; j++)
                    {
                        if (j == 1 || j == lines)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
