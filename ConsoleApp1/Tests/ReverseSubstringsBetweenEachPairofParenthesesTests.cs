using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ReverseSubstringsBetweenEachPairofParenthesesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "(abcd)";

            var result = new ReverseSubstringsBetweenEachPairofParentheses().ReverseParentheses(s);

            Assert.AreEqual("dcba", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "(u(love)i)";

            var result = new ReverseSubstringsBetweenEachPairofParentheses().ReverseParentheses(s);

            Assert.AreEqual("iloveu", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "(ed(et(oc))el)";

            var result = new ReverseSubstringsBetweenEachPairofParentheses().ReverseParentheses(s);

            Assert.AreEqual("leetcode", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "a(bcdefghijkl(mno)p)q";

            var result = new ReverseSubstringsBetweenEachPairofParentheses().ReverseParentheses(s);

            Assert.AreEqual("apmnolkjihgfedcbq", result);
        }
    }
}
