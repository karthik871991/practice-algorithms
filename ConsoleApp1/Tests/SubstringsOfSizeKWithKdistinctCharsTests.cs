using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class SubstringsOfSizeKWithKdistinctCharsTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = "abcabc";

            var result = new SubstringsOfSizeKWithKdistinctChars().KSubStrings(input, 3);
            var expected = new List<string> { "abc", "bca", "cab" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = "awaglknagawunagwkwagl";

            var result = new SubstringsOfSizeKWithKdistinctChars().KSubStrings(input, 4);
            var expected = new List<string> { "wagl", "aglk", "glkn", "lkna", "knag", "gawu", "awun", "wuna", "unag", "nagw", "agwk", "kwag" };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
