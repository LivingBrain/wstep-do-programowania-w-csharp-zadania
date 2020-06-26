using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program  wczytujący  3  liczby  rzeczywiste a, b, x,  a  następnie  wywołujący
             * metodę,  która  sprawdza,  czy  liczba x należy  do  przedziału  obustronnie  otwartego (a,  b).
             * Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie
             * Main() z podaniem stosownego komunikatu. 
             */

            Console.Write("Provide value a: ");
            int aValue = int.Parse(Console.ReadLine());
            Console.Write("Provide value b: ");
            int bValue = int.Parse(Console.ReadLine());
            Console.Write("Provide value x: ");
            int xValue = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Is x between a and b?: {CheckIfNumberIsBetween(aValue, bValue, xValue)}");
            Console.ReadKey();
        }

        private static bool CheckIfNumberIsBetween(int aValue, int bValue, int xValue)
        {
            return aValue < xValue && xValue < bValue ? true : false;
        }
    }
}
