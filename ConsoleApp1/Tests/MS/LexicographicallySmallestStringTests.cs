using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class LexicographicallySmallestStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("abczd");

            Assert.AreEqual("abcd", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("abcde");

            Assert.AreEqual("abcd", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("ba");

            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("abcded");

            Assert.AreEqual("abcdd", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new LexicographicallySmallestString().LexiSmallestString("dcba");

            Assert.AreEqual("cba", result);
        }
    }
}
