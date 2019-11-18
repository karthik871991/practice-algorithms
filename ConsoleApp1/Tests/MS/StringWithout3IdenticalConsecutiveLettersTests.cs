using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class StringWithout3IdenticalConsecutiveLettersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new StringWithout3IdenticalConsecutiveLetters().GetLongestSubString("eedaaad");

            Assert.AreEqual("eedaad", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new StringWithout3IdenticalConsecutiveLetters().GetLongestSubString("xxxtxxx");

            Assert.AreEqual("xxtxx", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new StringWithout3IdenticalConsecutiveLetters().GetLongestSubString("uuuuxaaaaxuuu");

            Assert.AreEqual("uuxaaxuu", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = new StringWithout3IdenticalConsecutiveLetters().GetLongestSubString("");

            Assert.AreEqual("", result);
        }
    }
}
