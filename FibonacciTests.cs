using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciGenerator
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void ReturnFirstFibonacciNumberWhenInputIs1()
        {
            const int expectedResult = 0;
            var result = Fibonacci.GetNumbers(1);
            Assert.AreEqual(expectedResult, result[0], "Expected a result of 0 but got something else");
        }

        [TestMethod]
        public void ReturnEmptyListWhenInputIs0()
        {
            var expectedResult = Enumerable.Empty<int>();
            var result = Fibonacci.GetNumbers(0);
            Assert.IsTrue(expectedResult.SequenceEqual(result), "Expected an empty list but got something else");
        }

        [TestMethod]
        public void ReturnEmptyListWhenInputIsNegative()
        {
            var expectedResult = Enumerable.Empty<int>();
            var result = Fibonacci.GetNumbers(-26);
            Assert.IsTrue(expectedResult.SequenceEqual(result), "Expected an empty list but got something else");
        }

        [TestMethod]
        public void ReturnFirst10FibonacciNumberWhenInputIs10()
        {
            var expectedResult = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var result = Fibonacci.GetNumbers(10);
            Assert.IsTrue(expectedResult.SequenceEqual(result),
                "Expected first 10 Fibonacci numbers; got something else");
        }

        [TestMethod]
        public void AllNumbersReturnedArePositiveWhenInputIsLarge()
        {
            var result = Fibonacci.GetNumbers(100);
            foreach (var number in result)
            {
                Assert.IsTrue(number > 0, "One or more numbers returned were negative");
            }
        }
    }
}