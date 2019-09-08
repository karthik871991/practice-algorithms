using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LongestSubstringWithAtMostKDistinctCharactersTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = "eceba";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().LengthOfLongestSubstringKDistinct(input, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = "ccaabbb";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().LengthOfLongestSubstringKDistinct(input, 2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test3()
        {
            var input = "aa";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().LengthOfLongestSubstringKDistinct(input, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test4()
        {
            var input = "aa";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().SubstringKDistinctCount(input, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test5()
        {
            var input = "pqpqs";

            var result = new LongestSubstringWithAtMostKDistinctCharacters().SubstringKDistinctCount(input, 2);

            Assert.AreEqual(7, result);
        }
    }
}