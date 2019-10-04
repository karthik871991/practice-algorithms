using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class SubarraySumEqualsKTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 1, 1, 1 };
            var result = new SubarraySumEqualsK().SubarraySum(input, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 1, 2, 1 };
            var result = new SubarraySumEqualsK().SubarraySum(input, 3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var result = new SubarraySumEqualsK().SubarraySum(input, 0);

            Assert.AreEqual(55, result);
        }
    }
}
