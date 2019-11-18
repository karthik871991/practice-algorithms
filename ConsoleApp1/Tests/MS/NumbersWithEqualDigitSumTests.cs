using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class NumbersWithEqualDigitSumTests
    {
        [TestMethod]
        public void Testmethod1()
        {
            var result = new NumbersWithEqualDigitSum().MaxSum(new int[] { 51, 71, 17, 42 });

            Assert.AreEqual(93, result);
        }

        [TestMethod]
        public void Testmethod2()
        {
            var result = new NumbersWithEqualDigitSum().MaxSum(new int[] { 42, 33, 60 });

            Assert.AreEqual(102, result);
        }

        [TestMethod]
        public void Testmethod3()
        {
            var result = new NumbersWithEqualDigitSum().MaxSum(new int[] { 51, 32, 43 });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Testmethod4()
        {
            var result = new NumbersWithEqualDigitSum().MaxSum(new int[] { 51 });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Testmethod5()
        {
            var result = new NumbersWithEqualDigitSum().MaxSum(new int[] { 51, 51, 51, 51, 51, 51 });

            Assert.AreEqual(102, result);
        }
    }
}
