using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class TopKFrequentWordsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
            var result = new TopKFrequentWords().TopKFrequent(input, 2);
            var output = new string[] { "i", "love" };

            CollectionAssert.AreEqual(output.ToList(), result.ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            var result = new TopKFrequentWords().TopKFrequent(input, 4);
            var output = new string[] { "the", "is", "sunny", "day" };

            CollectionAssert.AreEqual(output.ToList(), result.ToList());
        }
    }
}
