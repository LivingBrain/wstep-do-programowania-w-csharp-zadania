using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program,  który  tworzy  klasę Prostokat,   zawierającą  dwie  prywatne  dane
             * składowe: dlugosc, szerokosc,  dwie  prywatne  metody: powierzchnia(), obwod()oraz metodę
             * publiczną –Prezentuj()(która  wyświetla  powierzchnię  i  obwód  prostokąta)  i  konstruktor
             * inicjalizujący. W metodzie Main()zdefiniuj obiekt iuruchom dla niego metodę Prezentuj().
             */
            Prostokat prostokat = new Prostokat();

            Console.WriteLine("Prostokat");
            prostokat.Prezentuj(2, 4);
            Console.ReadKey();
        }

        
        public class Prostokat
        {
            private int dlugosc;
            private int szerokosc;

            private int Powierzchnia()
            {
                return dlugosc * szerokosc;
            }

            private int Obwod()
            {
                return 2 * dlugosc + 2 * szerokosc;
            }

            public void Prezentuj(int dlugosc, int szerokosc)
            {
                this.dlugosc = dlugosc;
                this.szerokosc = szerokosc;
                Console.WriteLine(Powierzchnia());
                Console.WriteLine(Obwod());
            }
        }
    }
}
