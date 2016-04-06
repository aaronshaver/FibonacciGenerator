using System;
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
            const ulong expectedResult = 0;
            var result = Fibonacci.GetNumbers(1);
            Assert.AreEqual(expectedResult, result.Numbers[0], "Expected a result of 0 but got something else");
        }

        [TestMethod]
        public void ReturnEmptyListWhenInputIs0()
        {
            var expectedResult = Enumerable.Empty<ulong>();
            var result = Fibonacci.GetNumbers(0);
            Assert.IsTrue(expectedResult.SequenceEqual(result.Numbers), "Expected an empty list but got something else");
        }

        [TestMethod]
        public void ReturnEmptyListWhenInputIsNegative()
        {
            var expectedResult = Enumerable.Empty<ulong>();
            var result = Fibonacci.GetNumbers(-26);
            Assert.IsTrue(expectedResult.SequenceEqual(result.Numbers), "Expected an empty list but got something else");
        }

        [TestMethod]
        public void ReturnFirst10FibonacciNumberWhenInputIs10()
        {
            var expectedResult = new List<ulong> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var result = Fibonacci.GetNumbers(10);
            Assert.IsTrue(expectedResult.SequenceEqual(result.Numbers),
                "Expected first 10 Fibonacci numbers; got something else");
        }

        [TestMethod]
        public void EachNumberInResultsIsEqualToOrLargerThanItsPrecedingNumber()
        {
            var result = Fibonacci.GetNumbers(100);
            var previousNumber = result.Numbers[0];
            foreach (var number in result.Numbers)
            {
                Assert.IsTrue(number >= previousNumber,
                    $"The numbers did not keep increasing; {number} was not larger than {previousNumber}");
                previousNumber = number;
            }
        }

        [TestMethod]
        public void SetTooLargeFlagToTrueWhenInputIsLargerThanMaxValue()
        {
            var result = Fibonacci.GetNumbers(Fibonacci.MaxValue + 100);
            Assert.IsTrue(result.TooLarge);
        }
    }
}