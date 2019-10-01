using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class GetEqualSubstringsWithinBudgetTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "abcd", t = "bcdf";

            var result = new GetEqualSubstringsWithinBudget().EqualSubstring(s, t, 3);
            
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "abcd", t = "cdef";

            var result = new GetEqualSubstringsWithinBudget().EqualSubstring(s, t, 3);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "abcd", t = "acde";

            var result = new GetEqualSubstringsWithinBudget().EqualSubstring(s, t, 0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "krrgw", t = "zjxss";

            var result = new GetEqualSubstringsWithinBudget().EqualSubstring(s, t, 19);

            Assert.AreEqual(2, result);
        }
    }
}
