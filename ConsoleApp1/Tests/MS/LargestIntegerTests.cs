using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class LargestIntegerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new LargestInteger().LargestInt(new int[] { 3, 2, -2, 5, -3 });

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new LargestInteger().LargestInt(new int[] { 1, 2, 3, -4 });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new LargestInteger().LargestInt(new int[] { -10, 10 });

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new LargestInteger().LargestInt(new int[] { });

            Assert.AreEqual(0, result);
        }
    }
}
