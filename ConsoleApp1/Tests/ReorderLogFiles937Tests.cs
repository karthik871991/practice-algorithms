using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ReorderLogFiles937Tests
    {
        [TestMethod]
        public void ReorderTest1()
        {
            var reorder = new ReorderLogFiles937();

            var result = reorder.ReorderLogFiles(new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" });

            var expectedResult = new string[] { "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ReorderTest2()
        {
            var reorder = new ReorderLogFiles937();

            var result = reorder.ReorderLogFiles(new string[] { "a1 123", "a1 100", "a2 abc abc", "a1 abc abc" });

            var expectedResult = new string[] { "a1 abc abc", "a2 abc abc", "a1 123", "a1 100" };

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ReorderTest3()
        {
            var reorder = new ReorderLogFiles937();

            var result = reorder.ReorderLogFiles(new string[] { "j mo", "5 m w", "g 07", "o 2 0", "t q h" });

            var expectedResult = new string[] { "5 m w", "j mo", "t q h", "g 07", "o 2 0" };

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
