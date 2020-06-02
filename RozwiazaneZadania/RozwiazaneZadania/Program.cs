using System;

namespace RozwiazaneZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz  program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch 
             * zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik 
             * operacji dla  podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5 
             * oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.
             */


            Console.WriteLine("Simple calculator");
            Console.Write("Provide first number: ");
            var firstNumber = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Provide second number: ");
            var secondNumber = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("What operation?: ");
            var operationSign = Console.ReadLine();

            Console.WriteLine($"Equation result: {SimpleCalculator(firstNumber, secondNumber, operationSign):0.0#}");

            Console.ReadKey();
        }

        private static double SimpleCalculator(double firstNumber, double secondNumber, string operationSign)
        {
            double result = 0;
            switch (operationSign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
