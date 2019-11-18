using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class DayofWeekTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new DayofWeek().Day("Wed", 2);

            Assert.AreEqual("Fri", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new DayofWeek().Day("Sat", 23);

            Assert.AreEqual("Mon", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new DayofWeek().Day("Fri", 5);

            Assert.AreEqual("Wed", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new DayofWeek().Day("Sat", 2);

            Assert.AreEqual("Mon", result);
        }
    }
}
