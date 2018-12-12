using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MostCommonWord819Tests
    {
        [TestMethod]
        public void TestMostCommonWord1()
        {
            string[] banned = new string[] { "hit" };
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var mcw = new MostCommonWord819();
            var result = mcw.MostCommonWord(paragraph, banned);

            Assert.AreEqual("ball", result);
        }

        [TestMethod]
        public void TestMostCommonWord2()
        {
            string[] banned = new string[] { "a" };
            string paragraph = "a, a, a, a, b,b,b,c, c";


            var mcw = new MostCommonWord819();
            var result = mcw.MostCommonWord(paragraph, banned);

            Assert.AreEqual("b", result);
        }
    }
}