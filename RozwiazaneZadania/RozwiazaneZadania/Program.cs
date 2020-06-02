using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić 
             * użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach. Wzór: 
             * BMI = masa / wzrost^2
             * 
             * a)Po  obliczeniu  wskaźnika  BMI  program  powinien  wyświetlać  stosowną  informację  w
             * zależności od wartości wskaźnika:
             * < 18,5 –niedowaga,
             * 18,5–24,99 –wartość prawidłowa,
             * ≥ 25,0 –nadwaga.
             * 
             * b)Korzystając  z  Wikipedii  rozszerz  program,  tak  abywyświetlał  komentarz  według
             * poszerzonej klasyfikacji zakresów wskaźnika BMI.
             */

            Console.WriteLine("BMI calculator.");
            Console.Write("Provide mass value in kg: ");
            var massValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            Console.Write("Provide height value in m: ");
            var heightValue = StringToDecimalParseAndDotReplace(Console.ReadLine());
            var bmiValue = BmiCalculator(massValue, heightValue);
            Console.WriteLine($"Calculated BMI: {bmiValue:0.##}");
            Console.WriteLine($"BMI indicator: {BmiIndicator(bmiValue)}");
            Console.ReadKey();
        }

        private static double BmiCalculator(double massValue, double heightValue)
        {
            var calculatedBmi = massValue / Math.Pow(heightValue, 2);
            return calculatedBmi;
        }

        private static double StringToDecimalParseAndDotReplace(string toConvert)
        {
            var dotReplaced = toConvert.Contains(".") ? toConvert.Replace(".", ",") : toConvert;
            var convertedValue = double.Parse(dotReplaced);
            return convertedValue;
        }

        private static string BmiIndicator(double calculatedBmi)
        {
            var indicator = "";
            if (calculatedBmi < 16.0)
            {
                indicator = "Wygłodzenie";
            }
            else if (calculatedBmi < 16.99)
            {
                indicator = "Wychudzenie";
            }
            else if (calculatedBmi < 18.49)
            {
                indicator = "Niedowaga";
            }
            else if (calculatedBmi < 24.99)
            {
                indicator = "Pożądana masa ciała";
            }
            else if (calculatedBmi < 29.99)
            {
                indicator = "Nadwaga";
            }
            else if (calculatedBmi < 34.99)
            {
                indicator = "Otyłość I stopnia";
            }
            else if (calculatedBmi < 39.99)
            {
                indicator = "Otyłość II stopnia (duża)";
            }
            else
            {
                indicator = "Otyłość III stopnia (chorobliwa)";
            }

            return indicator;
        }
    }
}
