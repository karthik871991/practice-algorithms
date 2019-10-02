using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class RelativeSortArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr1 = new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            var arr2 = new int[] { 2, 1, 4, 3, 9, 6 };
            var result = new RelativeSortArray().RelativeSortArrays(arr1, arr2);

            var expected = new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
