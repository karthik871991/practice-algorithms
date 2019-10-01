using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class RemoveAllAdjacentDuplicatesinStringIITests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "abcd";

            var result = new RemoveAllAdjacentDuplicatesinStringII().RemoveDuplicates(input, 2);
            var expected = "abcd";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = "deeedbbcccbdaa";

            var result = new RemoveAllAdjacentDuplicatesinStringII().RemoveDuplicates(input, 3);
            var expected = "aa";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = "pbbcggttciiippooaais";

            var result = new RemoveAllAdjacentDuplicatesinStringII().RemoveDuplicates(input, 2);
            var expected = "ps";

            Assert.AreEqual(expected, result);
        }
    }
}