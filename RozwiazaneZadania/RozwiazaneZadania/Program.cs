using System;
using System.Text.RegularExpressions;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
             * przyjmie wartość 0. Odpowiedz dlaczego i zmień program (w linii, gdzie jest obliczana 
             * zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1 (czyli 10/100):
             * int powierzchnia = 100, osoby = 10;
             * double gestoscZaludnienia = osoby/powierzchnia;
             * Console.WriteLine(gestoscZaludnienia);
             */

            //int powierzchnia = 100, osoby = 10; 
            double powierzchnia = 100, osoby = 10; // With two values as integer the arithmetic is performed as integer arithmetic. This require to be performed as float.
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);

            Console.ReadKey();
        }
    }
}
