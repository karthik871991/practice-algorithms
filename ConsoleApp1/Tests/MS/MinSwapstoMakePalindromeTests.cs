using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MinSwapstoMakePalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("mamad");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("asflkj");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("ntiin");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("madam");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("toato");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("asflkj");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("frrfrra");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("aa");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod15()
        {
            var result = new MinSwapstoMakePalindrome().MinSwaps("aad");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("nitin");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("asflkj");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("madam");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("abcddcba");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("abcdcba");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var result = new MinSwapstoMakePalindrome().CanBePalindrome("mamad");

            Assert.IsTrue(result);
        }

    }
}
