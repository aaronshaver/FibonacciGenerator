using System;
using System.Collections.Generic;

namespace FibonacciGenerator
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            var iterations = GetNumberOfIterations();
            var numbers = Fibonacci.GetNumbers(iterations);
            var numbersText = GetFormattedNumbers(numbers);
            PrintOutput(iterations, numbersText);
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

        private static string GetFormattedNumbers(List<int> numbers)
        {
            var numbersText = "";
            foreach (var number in numbers)
            {
                numbersText += number + ", ";
            }
            numbersText = numbersText.TrimEnd(',', ' ');
            return numbersText;
        }

        private static void PrintOutput(int iterations, string numbersText)
        {
            Console.WriteLine($"\nHere are the {iterations} Fibonacci number(s) you asked for:");
            Console.WriteLine(numbersText);
            Console.WriteLine("\nPress <Enter> key to continue...");
            Console.ReadLine();
        }
    }
}