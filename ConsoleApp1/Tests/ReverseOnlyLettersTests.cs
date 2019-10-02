using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ReverseOnlyLettersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "ab-cd";
            var result = new ReverseOnlyLetters().ReverseOnlyLetter(input);

            Assert.AreEqual("dc-ba", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = "a-bC-dEf-ghIj";
            var result = new ReverseOnlyLetters().ReverseOnlyLetter(input);

            Assert.AreEqual("j-Ih-gfE-dCba", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = "Test1ng-Leet=code-Q!";
            var result = new ReverseOnlyLetters().ReverseOnlyLetter(input);

            Assert.AreEqual("Qedo1ct-eeLg=ntse-T!", result);
        }
    }
}
