using AlgoPractice.MS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.MS
{
    [TestClass]
    public class ReplaceQuestionMarkTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new ReplaceQuestionMark(). Solution("ab?ac?");
            Assert.AreEqual("abcaca", result);
            var result1 = new ReplaceQuestionMark().Solution("?????");
            Assert.AreEqual("ababa", result1);
            var result2 = new ReplaceQuestionMark().Solution("abcd");
            Assert.AreEqual("abcd", result2);
            var result3 = new ReplaceQuestionMark().Solution("z??z");
            Assert.AreEqual("zabz", result3);
            var result4 = new ReplaceQuestionMark().Solution("");
            Assert.AreEqual("", result4);
            var result5 = new ReplaceQuestionMark().Solution("?");
            Assert.AreEqual("a", result5);
            var result6 = new ReplaceQuestionMark().Solution("??");
            Assert.AreEqual("ab", result6);
            var result7 = new ReplaceQuestionMark().Solution("???");
            Assert.AreEqual("aba", result7);
            var result8 = new ReplaceQuestionMark().Solution("?a?");
            Assert.AreEqual("bab", result8);
            var result9 = new ReplaceQuestionMark().Solution("?z?");
            Assert.AreEqual("aza", result9);
        }
    }
}
