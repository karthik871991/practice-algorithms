using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MaxInsertstoObtainStringWithout3ConsecutiveaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aabab");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("dog");

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aa");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aaa");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("baaa");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aaba");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aaa");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var result = new MaxInsertstoObtainStringWithout3Consecutivea().MaxInserts("aaa");

            Assert.AreEqual(-1, result);
        }
    }
}
