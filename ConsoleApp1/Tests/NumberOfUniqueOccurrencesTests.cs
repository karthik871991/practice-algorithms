using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NumberOfUniqueOccurrencesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 2, 1, 1, 3 };

            var result = new NumberOfUniqueOccurrences().UniqueOccurrences(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2 };

            var result = new NumberOfUniqueOccurrences().UniqueOccurrences(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };

            var result = new NumberOfUniqueOccurrences().UniqueOccurrences(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = new int[] { 3, 5, -2, -3, -6, -6 };

            var result = new NumberOfUniqueOccurrences().UniqueOccurrences(input);

            Assert.IsFalse(result);
        }
    }
}