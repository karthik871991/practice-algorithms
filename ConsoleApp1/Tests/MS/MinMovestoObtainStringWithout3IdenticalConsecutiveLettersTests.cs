using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class MinMovestoObtainStringWithout3IdenticalConsecutiveLettersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new MinMovestoObtainStringWithout3IdenticalConsecutiveLetters().MinNoMoves("baaaaa");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new MinMovestoObtainStringWithout3IdenticalConsecutiveLetters().MinNoMoves("baaabbaabbba");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = new MinMovestoObtainStringWithout3IdenticalConsecutiveLetters().MinNoMoves("baabab");

            Assert.AreEqual(0, result);
        }
    }
}
