using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o
             * wysokości przysługującego stypendium zgodnie z poniższą tabelą:
             * 2,00 3,99 0,00 zł
             * 4,00 4,79 350,00 zł
             * 4,80 5,00 550,00 zł
             */

            Console.WriteLine("Scholarship Amount.");
            Console.Write("Provide average grade: ");
            var averageGrade = StringToDecimalParseAndDotReplace(Console.ReadLine());
            Console.WriteLine($"Scholarship Amount: {ScholarshipAmount(averageGrade)}");
            Console.ReadKey();
        }

        private static double StringToDecimalParseAndDotReplace(string toConvert)
        {
            var dotReplaced = toConvert.Contains(".") ? toConvert.Replace(".", ",") : toConvert;
            var convertedValue = double.Parse(dotReplaced);
            return convertedValue;
        }

        private static string ScholarshipAmount(double averageGrade)
        {
            var scholarshipAmount = 0;
            switch (averageGrade)
            {
                case var i when i >= 2.0 && i <= 3.99:
                    scholarshipAmount = 0;
                    break;
                case var i when i >= 4.0 && i <= 4.79:
                    scholarshipAmount = 350;
                    break;
                case var i when i >= 4.80 && i <= 5.00:
                    scholarshipAmount = 550;
                    break;
            }

            return $"{scholarshipAmount:0.##} zł";
        }
    }
}
