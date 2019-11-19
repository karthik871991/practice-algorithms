using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PartitiontoKEqualSumSubsetsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 4, 3, 2, 3, 5, 2, 1 };
            var result = new PartitiontoKEqualSumSubsets().CanPartitionKSubsets(input, 4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 4, 3, 2, 3, 5, 2, 1, 1 };
            var result = new PartitiontoKEqualSumSubsets().CanPartitionKSubsets(input, 4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[] { 4, 3, 2, 3, 5, 2, 1, 1 };
            var result = new PartitiontoKEqualSumSubsets().CanPartitionKSubsets(input, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = new int[] { 10, 10, 10, 7, 7, 7, 7, 7, 7, 6, 6, 6 };
            var result = new PartitiontoKEqualSumSubsets().CanPartitionKSubsets(input, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var input = new int[] { 2, 2, 10, 5, 2, 7, 2, 2, 13 };
            var result = new PartitiontoKEqualSumSubsets().CanPartitionKSubsets(input, 3);
            Assert.IsTrue(result);
        }
    }
}
