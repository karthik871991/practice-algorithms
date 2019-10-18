using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class Word_LadderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            var result = new Word_Ladder().LadderLength("hit", "cog", list);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var list = new List<string> { "hot", "dot", "dog", "lot", "log" };
            var result = new Word_Ladder().LadderLength("hit", "cog", list);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var list = new List<string> { "a", "b", "c" };
            var result = new Word_Ladder().LadderLength("a", "c", list);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var list = new List<string> { "a", "b", "c", "d", "e", "f" };
            var result = new Word_Ladder().LadderLength("a", "f", list);

            Assert.AreEqual(2, result);
        }
    }
}
