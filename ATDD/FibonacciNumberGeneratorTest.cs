using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSP._3_before;

namespace ATDD
{
    [TestClass]
    public class FibonacciNumberGeneratorTest
    {
        [TestMethod]
        public void First5FibonacciNumbersShouldMatch()
        {
            int[] expected = new int[] { 0, 1, 1, 2, 3 };

            int[] actual = new FibonacciNumberGenerator().GetSequenceOfLength(5);

            Assert.AreEqual(expected.Length, actual.Length);
        }

        public FibonacciNumberGenerator CreateFibonacciNumberGenerator()
        {
            return new FibonacciNumberGenerator();
        }
    }
}
