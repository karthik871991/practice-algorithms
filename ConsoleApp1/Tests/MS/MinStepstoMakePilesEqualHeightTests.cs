using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MinStepstoMakePilesEqualHeightTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MinStepstoMakePilesEqualHeight().MinimumSteps(new int[] { 5, 2, 1 });

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MinStepstoMakePilesEqualHeight().MinimumSteps(new int[] { 4, 5, 5, 4, 2 });

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MinStepstoMakePilesEqualHeight().MinimumSteps(new int[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new MinStepstoMakePilesEqualHeight().MinimumSteps(new int[] { 1, 2 });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = new MinStepstoMakePilesEqualHeight().MinimumSteps(new int[] { 1 });

            Assert.AreEqual(0, result);
        }
    }
}
