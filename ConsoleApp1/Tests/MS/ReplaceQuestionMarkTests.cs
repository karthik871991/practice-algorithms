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
            var result1 = new ReplaceQuestionMark().Solution("?????");
            var result2 = new ReplaceQuestionMark().Solution("abcd");
            var result3 = new ReplaceQuestionMark().Solution("z??z");
        }
    }
}
