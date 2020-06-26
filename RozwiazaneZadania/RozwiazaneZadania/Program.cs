using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor. 
             * W   metodzie Main()wczytaj   od  użytkownika  współrzędne  punktu Aoraz   zadeklaruj 
             * współrzędne wektorawek[3, 2], a następnie wywołaj metodę o nazwie Przesun(), która ma 
             * przesunąć  punkt A o  wektor wek(dodać  odpowiednie  współrzędne).  Współrzędne  punktu
             * (jako  dwie  zmienne  typu double)  mają zostać przesłane do tej  metody  przez referencję, a 
             * współrzędne  wektora  (także  jako  dwie  zmienne  typu double)  przez  wartość.  Metoda 
             * Przesun()ma nic nie zwracać (void), aktualne współrzędne punktu mają być pamiętane dzięki
             * użyciu  argumentów  przesyłanych przez  referencje.  Program  ma  wyświetlić  współrzędne
             * punktu po przesunięciu  o wektor wek. Przykładowo, gdyby użytkownik podał początkowe 
             * współrzędne  punktu A(2,  1),  to  wówczas  program  znajdzie  położenie  punktu A po 
             * przesunięciu w miejscu o współrzędnych (5, 3) (czyli 2+3, 1+2).
             */
            var aPoint = new int[2];
            var vector = new int[2] { 3, 2 };

            Console.Write("Provide first value of a point: ");
            int aValue = int.Parse(Console.ReadLine());
            Console.Write("Provide second value of a point: ");
            int bValue = int.Parse(Console.ReadLine());
            aPoint[0] = aValue;
            aPoint[1] = bValue;

            Przesun(ref aPoint, vector);

            Console.WriteLine($"A point values: [{aPoint[0]}, {aPoint[1]}] ");
            Console.ReadKey();
        }

        private static void Przesun(ref int[] aPoint, int[] vector)
        {
            aPoint[0] += vector[0];
            aPoint[1] += vector[1];
        }
    }
}
