using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.MS
{
    [TestClass]
    public class MaxNetworkRankTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MaxNetworkRank().MaxRank(new int[] { 1, 2, 3, 3 }, new int[] { 2, 3, 1, 4 }, 4);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MaxNetworkRank().MaxRank(new int[] { 1, 2, 4, 5 }, new int[] { 2, 3, 5, 6 }, 6);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MaxNetworkRank().MaxRank(new int[] { 1, 1, 1, 1, 1, 1, 2, 2 }, new int[] { 2, 3, 4, 5, 6, 7, 3, 4 }, 7);

            Assert.AreEqual(8, result);
        }
    }
}