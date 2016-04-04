using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciGenerator
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void GetFirstNumber()
        {
            const int expectedResult = 0;
            var result = Fibonacci.GetNumbers(1);
            Assert.AreEqual(expectedResult, result[0]);
        }
    }
}