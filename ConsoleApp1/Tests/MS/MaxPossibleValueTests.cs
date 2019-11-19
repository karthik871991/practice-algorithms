using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MaxPossibleValueTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MaxPossibleValue().MaxValue(268);

            Assert.AreEqual(5268, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MaxPossibleValue().MaxValue(862);

            Assert.AreEqual(8652, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MaxPossibleValue().MaxValue(999);

            Assert.AreEqual(9995, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MaxPossibleValue().MaxValue(1263);

            Assert.AreEqual(51263, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MaxPossibleValue().MaxValue(555);

            Assert.AreEqual(5555, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MaxPossibleValue().MaxValue(4631);

            Assert.AreEqual(54631, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MaxPossibleValue().MaxValue(6490);

            Assert.AreEqual(65490, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var result = new MaxPossibleValue().MaxValue(0);

            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var result = new MaxPossibleValue().MaxValue(-999);

            Assert.AreEqual(-5999, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var result = new MaxPossibleValue().MaxValue(-462);

            Assert.AreEqual(-4562, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var result = new MaxPossibleValue().MaxValue(000);

            Assert.AreEqual(50, result);
        }
    }
}
