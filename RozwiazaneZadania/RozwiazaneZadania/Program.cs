using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jaką wartość przyjmą zmienne użyte w programie po wykonaniu poniższych instrukcji? 
             * Najpierw ustal wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program
                a)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
                b)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
                c)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
                d)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 || y++ > 2 || ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
                e)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 || ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
                f)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 | ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); 
             */

            Console.WriteLine("a)");
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("b)");
            x = 1;
            y = 4; 
            z = 2;
            wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("c)");
            x = 1;
            y = 4; 
            z = 2;
            wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("d)");
            x = 1;
            y = 3; 
            z = 4;
            wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("e)");
            x = 1;
            y = 3; 
            z = 4;
            wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.WriteLine("f)");
            x = 1;
            y = 3; 
            z = 4;
            wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.ReadKey();
        }
    }
}
