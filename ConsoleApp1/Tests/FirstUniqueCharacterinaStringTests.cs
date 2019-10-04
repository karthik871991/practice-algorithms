using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class FirstUniqueCharacterinaStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new FirstUniqueCharacterinaString().FirstUniqChar("leetcode");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new FirstUniqueCharacterinaString().FirstUniqChar("loveleetcode");

            Assert.AreEqual(2, result);
        }
    }
}
