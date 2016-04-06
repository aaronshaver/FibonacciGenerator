using System;
using System.Collections.Generic;

namespace FibonacciGenerator
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            var iterations = GetNumberOfIterations();
            var result = Fibonacci.GetNumbers(iterations);
            var numbersText = GetFormattedNumbers(result);
            PrintOutput(numbersText, result.TooLarge);
        }

        private static int GetNumberOfIterations()
        {
            int iterations;
            bool validNumber;
            do
            {
                Console.WriteLine("How many Fibonacci numbers would you like to print? ");
                var rawInput = Console.ReadLine();
                validNumber = int.TryParse(rawInput, out iterations);
            } while (!validNumber);
            return iterations;
        }

        private static string GetFormattedNumbers(Fibonacci.FibonacciResult result)
        {
            var numbersText = "";
            foreach (var number in result.Numbers)
            {
                numbersText += number + "\n";
            }
            return numbersText;
        }

        private static void PrintOutput(string numbersText, bool tooLarge)
        {
            if (numbersText != String.Empty)
            {
                Console.WriteLine("\nHere are the Fibonacci number(s) you asked for.");
                Console.WriteLine(numbersText);
                if (tooLarge)
                {
                    Console.WriteLine("*** WARNING: your results have been truncated!");
                    Console.WriteLine($"This app can only print the first {Fibonacci.MaxValue} Fibonacci numbers.\n");
                }
            }
            else
            {
                Console.WriteLine("\n*** WARNING: your input resulted in no numbers.");
                Console.WriteLine($"Valid inputs are whole numbers between 1 and {Fibonacci.MaxValue} inclusive.");
            }
            
            Console.WriteLine("Press <Enter> key to continue...");
            Console.ReadLine();
        }
    }
}
