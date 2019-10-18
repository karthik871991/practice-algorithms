using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MinimumSizeSubarraySumTests
    {
        [TestMethod]
        public void testMethod1()
        {
            var input = new int[] { 2, 3, 1, 2, 4, 3 };
            var result = new MinimumSizeSubarraySum().MinSubArrayLen(7, input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void testMethod2()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = new MinimumSizeSubarraySum().MinSubArrayLen(100, input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void testMethod3()
        {
            var input = new int[] { 1, 4, 4 };
            var result = new MinimumSizeSubarraySum().MinSubArrayLen(4, input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void testMethod4()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var result = new MinimumSizeSubarraySum().MinSubArrayLen(11, input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void testMethod5()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var result = new MinimumSizeSubarraySum().MinSubArrayLen(15, input);

            Assert.AreEqual(5, result);
        }
    }
}
