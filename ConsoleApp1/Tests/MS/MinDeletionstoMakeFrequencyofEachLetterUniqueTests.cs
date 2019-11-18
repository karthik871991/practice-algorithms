using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MinDeletionstoMakeFrequencyofEachLetterUniqueTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("eeeeffff");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("aabbffddeaee");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("llll");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("example");

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("aaaabbbbccccddeef");

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("aaaaee");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MinDeletionstoMakeFrequencyofEachLetterUnique().MinimumDeletions("aaaaaa");

            Assert.AreEqual(0, result);
        }
    }
}
