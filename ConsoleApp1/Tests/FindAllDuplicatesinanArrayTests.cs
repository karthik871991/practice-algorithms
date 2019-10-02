using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class FindAllDuplicatesinanArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var result = new FindAllDuplicatesinanArray().FindDuplicates(input);
            IList<int> expOutput = new List<int> { 2, 3 };

            CollectionAssert.AreEqual(expOutput.ToList(), result.ToList());
        }
    }
}
