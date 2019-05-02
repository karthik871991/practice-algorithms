using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class KClosestPointsToOrgin973Tests
    {
        [TestMethod]
        public void ClosestPointsTest()
        {
            var test = new KClosestPointsToOrgin973();

            var input = new int[2][];
            input[0] = new int[] { 0, 1 };
            input[1] = new int[] { 1, 0 };
            //input[2] = new int[] { 0, 0 };


            var result = test.KClosest(input, 2);

            Console.WriteLine(result[0][0]);
            Console.WriteLine(result[0][1]);
            
            var exp = new int[2][];
            exp[0] = new int[] { 0, 1 };
            exp[1] = new int[] { 1, 0 };

            Console.WriteLine(exp[0][0]);
            Console.WriteLine(exp[0][1]);

            Assert.AreEqual(exp[0][0], result[0][0]);
            Assert.AreEqual(exp[0][1], result[0][1]);

        }

    }
}