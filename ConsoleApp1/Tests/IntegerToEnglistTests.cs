using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class IntegerToEnglistTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(123);

            Assert.AreEqual("One Hundred Twenty Three", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(12345);

            Assert.AreEqual("Twelve Thousand Three Hundred Forty Five", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(1234567);

            Assert.AreEqual("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(1234567891);

            Assert.AreEqual("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(20);

            Assert.AreEqual("Twenty", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var sut = new IntegerToEnglish();

            var result = sut.NumberToWords(1000);

            Assert.AreEqual("One Thousand", result);
        }
    }
}
