using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MinSwapstoGroupRedBallsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WRRWWR");

            Assert.AreEqual(2, result);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WWRWWWRWR");

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WWRWWWRWRRR");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WWW");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("RW");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WRRWWR");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("RRRWWWRRW");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("RRRRR");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("RWWWR");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WWW");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var result = new MinSwapstoGroupRedBalls().MinimumSwaps("WWW");

            Assert.AreEqual(0, result);
        }
    }
}
