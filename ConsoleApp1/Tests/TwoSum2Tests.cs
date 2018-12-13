using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class TwoSum2Tests
    {
        [TestMethod]
        public void TwoSumTest()
        {
            var intArr = new int[4] { 2, 7, 11, 15 };
            var target = 9;
            var twoSum = new TwoSum1();
            var result = twoSum.TwoSum(intArr, target);

            Assert.IsTrue(result.Contains(0));
            Assert.IsTrue(result.Contains(1));
            Assert.IsTrue(result.Aggregate((x, y) => intArr[x] + intArr[y]) == target);
        }

        [TestMethod]
        public void TwoSumWithSameKey()
        {
            var intArr = new int[4] { 2, 2, 11, 15 };
            var target = 9;
            var twoSum = new TwoSum1();
            var result = twoSum.TwoSum(intArr, target);

            Assert.IsNull(result);
        }
    }
}