using System;
using System.Collections.Generic;

namespace FibonacciGenerator
{
    public static class Fibonacci
    {
        public static List<int> GetNumbers(int iterations)
        {
            var result = new List<int>();
            if (!(iterations > 0)) return result;

            var previousNumber = 0;
            result.Add(previousNumber);
            var nextNumber = 1;
            var counter = 1;

            while (counter < iterations)
            {
                result.Add(nextNumber);
                var currentNumber = nextNumber;
                nextNumber += previousNumber;
                previousNumber = currentNumber;
                counter += 1;
            }
            return result;
        }
    }
}