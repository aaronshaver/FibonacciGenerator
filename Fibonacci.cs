using System.Collections.Generic;
using System.Linq;

namespace FibonacciGenerator
{
    public static class Fibonacci
    {
        public const int MaxValue = 94;

        public static FibonacciResult GetNumbers(int iterations)
        {
            var result = new FibonacciResult();
            if (!(iterations > 0)) return result;

            ulong previousNumber = 0;
            result.AddNumber(previousNumber);
            ulong nextNumber = 1;
            var counter = 1;

            while (counter < iterations)
            {
                result.AddNumber(nextNumber);
                var currentNumber = nextNumber;
                nextNumber += previousNumber;
                previousNumber = currentNumber;
                counter += 1;
            }
            return result;
        }

        public class FibonacciResult
        {
            public bool TooLarge { get; set; }
            public List<ulong> Numbers { get; } = new List<ulong>();

            public void AddNumber(ulong number)
            {
                // ulong starts overflowing once we exceed the Fibonacci number
                // 12200160415121876738, so we raise a red flag with the TooLarge property.
                //
                // If you want to extend this class to support very large numbers, you could
                // try using the BigInteger type. You may need to add an assembly reference to
                // System.Numerics and add 'using System.Numerics;' at the top of this file
                if (Numbers.Count < MaxValue) Numbers.Add(number);
                else TooLarge = true;
            }
        }
    }
}