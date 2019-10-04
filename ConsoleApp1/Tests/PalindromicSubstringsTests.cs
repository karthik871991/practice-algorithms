using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PalindromicSubstringsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "abc";

            var result = new PalindromicSubstrings().CountSubstrings(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = "aaa";

            var result = new PalindromicSubstrings().CountSubstrings(input);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = "ababa";

            var result = new PalindromicSubstrings().CountSubstrings(input);

            Assert.AreEqual(9, result);
        }
    }
}
