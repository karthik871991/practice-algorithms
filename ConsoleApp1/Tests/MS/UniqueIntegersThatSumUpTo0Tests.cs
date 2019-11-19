using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class UniqueIntegersThatSumUpTo0Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new UniqueIntegersThatSumUpTo0().UniqueIntegers(4);

            CollectionAssert.AreEqual(new int[] { -2, -1, 1, 2 }.OrderBy(x => x).ToList(), result.OrderBy(x => x).ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new UniqueIntegersThatSumUpTo0().UniqueIntegers(5);

            CollectionAssert.AreEqual(new int[] { -2, -1, 0, 1, 2 }.OrderBy(x => x).ToList(), result.OrderBy(x => x).ToList());
        }
    }
}
