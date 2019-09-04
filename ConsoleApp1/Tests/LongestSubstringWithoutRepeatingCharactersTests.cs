using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = "pwwkew";

            var result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = "abcabcbb";

            var result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test3()
        {
            var input = "bbbbb";

            var result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test4()
        {
            var input = "abba";

            var result = new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(input);

            Assert.AreEqual(2, result);
        }
    }
}
