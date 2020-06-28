using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jaki będzie rezultat metody Oblicz()wywołanej z parametrem n = 5? Zadanie wykonaj 
             * najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany
             * wynik.
             * static int Oblicz(int n)
             * {
             * if (n <= 1) return (1);
             * else return (n + Oblicz(n -1));
             * }
             */

            Console.WriteLine(Oblicz(5));

            Console.ReadKey();
        }

        // (n + Oblicz(n - 1))
        // 5 + Oblicz(5 - 1) => 4 + Oblicz(4 - 1) => 3 + Oblicz(3 - 1) => 2 + Oblicz(2 - 1) => 1
        // 5 + 10            => 4 + 6             => 3 + 3             => 2 + 1             => 1
        // Result = 15

        public static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
    }
}
