using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class HighFivesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[][] { new int[] { 1, 91 },
                                      new int[] { 1, 92 },
                                      new int[] { 2, 93 },
                                      new int[] { 2, 97 },
                                      new int[] { 1, 60 },
                                      new int[] { 2, 77 },
                                      new int[] { 1, 65 },
                                      new int[] { 1, 87 },
                                      new int[] { 1, 100 },
                                      new int[] { 2, 100 },
                                      new int[] { 2, 76 },
            };

            var result = new HighFives().HighFive(input);


        }
    }
}
