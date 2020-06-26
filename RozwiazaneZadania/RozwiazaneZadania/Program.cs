using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który wypisze na ekranie znaki w kształcie prostokąta. Program ma 
             * prosić użytkownika o podanie rozmiaru prostokąta: długość i szerokość, a następnie znak,
             * którym  ma  być  zapełniony  prostokąt.  Napisz  metodę Rysuj(),  która  wypisze  na  konsoli
             * prostokąt,  przesyłając  jako  argument  długość,  szerokość  oraz  znak  wypełnienia.  Wywołaj 
             * metodę dwa razy, za drugim razem podaj na odwrót argumenty dla długości i szerokości.
             * W wyniku działania programu powinny zostać wyświetlone dwa prostokąty, jeden „leżący”
             * oraz  drugi „stojący”. Przykładowy przebieg działania programu na rysunku:
             */

            Console.Write("Provide rectangle length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Provide rectangle width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Provide rectangle fill character: ");
            string fillChar = Console.ReadLine();

            PrintObject(length, width, fillChar);
            Console.WriteLine();
            PrintObject(width, length, fillChar);

            Console.ReadKey();
        }

        private static void PrintObject(int length, int width, string fillChar)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(fillChar);
                }
                Console.WriteLine();
            }
        }

    }
}
