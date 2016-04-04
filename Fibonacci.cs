using System.Collections.Generic;

namespace FibonacciGenerator
{
    public static class Fibonacci
    {
        public static List<int> GetNumbers(int iterations)
        {
            var result = new List<int>();
            if (iterations > 0) result.Add(0);
            return result;

//            var numbers = new List<int>();
//            var previousNumber = 0;
//            var nextNumber = 1;
//            Console.WriteLine(previousNumber);
//            do
//            {
//                numbers.Add(nextNumber);
//                var currentNumber = nextNumber;
//                nextNumber += previousNumber;
//                previousNumber = currentNumber;
//            } while (nextNumber < iterations);
//            return numbers;
        }
    }
}