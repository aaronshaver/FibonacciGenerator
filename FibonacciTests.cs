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

    }
}