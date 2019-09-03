using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MinCostToConnectRopesTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = new List<int> { 8, 4, 6, 12 };
            var result = new MinCostToConnectRopes().MinCost(input);
            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = new List<int> { 20, 4, 8, 2 };
            var result = new MinCostToConnectRopes().MinCost(input);
            Assert.AreEqual(54, result);
        }

        [TestMethod]
        public void Test3()
        {
            var input = new List<int> { 1, 2, 5, 10, 35, 89 };
            var result = new MinCostToConnectRopes().MinCost(input);
            Assert.AreEqual(224, result);
        }

        [TestMethod]
        public void Test4()
        {
            var input = new List<int> { 2, 2, 3, 3 };
            var result = new MinCostToConnectRopes().MinCost(input);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test5()
        {
            var input = new List<int> { 5 };
            var result = new MinCostToConnectRopes().MinCost(input);
            Assert.AreEqual(5, result);
        }
    }
}
