using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.MS
{
    [TestClass]
    public class MaxNetworkRankTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MaxNetworkRank().solution(new int[] { 1, 2, 3, 3 }, new int[] { 2, 3, 1, 4 }, 4);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MaxNetworkRank().solution(new int[] { 1, 2, 4, 5 }, new int[] { 2, 3, 5, 6 }, 6);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MaxNetworkRank().solution(new int[] { 1, 1, 1, 1, 1, 1, 2, 2 }, new int[] { 2, 3, 4, 5, 6, 7, 3, 4 }, 7);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MaxNetworkRank().MaxLength(new List<string> 
            { "co", "dil", "ity" });

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MaxNetworkRank().MaxLength(new List<string> 
            { "abc", "yyy", "def", "csv" });

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MaxNetworkRank().MaxLength(new List<string> 
            { "potato", "kayak", "banana", "racecar" });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MaxNetworkRank().MaxLength(new List<string>
            { "eva", "jqw", "tyn", "jan" });

            Assert.AreEqual(9, result);
        }
    }
}