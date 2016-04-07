using System;

namespace FibonacciGenerator
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            do
            {
                var userInput = GetUserInput();
                if (userInput == "") break;
                var parsedIterations = GetParsedIterations(userInput);
                var result = Fibonacci.GetNumbers(parsedIterations);
                var numbersText = GetFormattedNumbers(result);
                PrintOutput(numbersText, result.TooLarge);
            } while (true);
        }

        private static string GetUserInput()
        {
            Console.WriteLine("How many Fibonacci numbers would you like to print?");
            Console.WriteLine("(press <Enter> key without inputting anything to exit program)");
            return Console.ReadLine();
        }

        private static int GetParsedIterations(string rawInput)
        {
            var iterations = 0;
            int.TryParse(rawInput, out iterations);
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
                Console.WriteLine($"Valid inputs are whole numbers between 1 and {Fibonacci.MaxValue} inclusive.\n");
            }
        }
    }
}
