using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class LongestSubstringWithAtMostKDistinctCharactersTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = "eceba";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().LengthOfLongestSubstringTwoDistinct(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = "ccaabbb";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().LengthOfLongestSubstringTwoDistinct(input);

            Assert.AreEqual(5, result);
        }

    }
}
