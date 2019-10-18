using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class LongestCommonSubsequenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new LongestCommonSubsequence().LongestCommonSubsequences("abcdefgh", "bdegabch");

            Assert.AreEqual(5, result);
        }

    }
}
