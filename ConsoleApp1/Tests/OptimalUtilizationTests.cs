using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class OptimalUtilizationTests
    {
        [TestMethod]
        public void Test1()
        {
            int[,] a1 = { { 1, 3 }, { 2, 5 }, { 3, 7 }, { 4, 10 } };
            int[,] b1 = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<int[]> { new int[] { 2, 4 }, new int[] { 3, 2 } };

            var resultString = new List<string>();

            foreach (var item in result)
            {
                resultString.Add(item[0] + "" + item[1]);
            }

            var outputString = new List<string>();

            foreach (var item in output)
            {
                outputString.Add(item[0] + "" + item[1]);
            }

            CollectionAssert.AreEqual(outputString, resultString);
        }

        [TestMethod]
        public void Test2()
        {
            int[,] a1 = { { 1, 3 }, { 2, 5 }, { 3, 7 }, { 4, 10 }, { 5, 7 } };
            int[,] b1 = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<int[]> { new int[] { 2, 4 }, new int[] { 3, 2 }, new int[] { 5, 2 } };

            var resultString = new List<string>();

            foreach (var item in result)
            {
                resultString.Add(item[0] + "" + item[1]);
            }

            var outputString = new List<string>();

            foreach (var item in output)
            {
                outputString.Add(item[0] + "" + item[1]);
            }

            CollectionAssert.AreEqual(outputString, resultString);
        }


        [TestMethod]
        public void Test3()
        {
            int[,] a1 = { { 1, 2 }, { 2, 4 }, { 3, 6 } };
            int[,] b1 = { { 1, 2 } };
            int target = 7;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<int[]> { new int[] { 2, 1 } };

            var resultString = new List<string>();

            foreach (var item in result)
            {
                resultString.Add(item[0] + "" + item[1]);
            }

            var outputString = new List<string>();

            foreach (var item in output)
            {
                outputString.Add(item[0] + "" + item[1]);
            }

            CollectionAssert.AreEqual(outputString, resultString);
        }

        [TestMethod]
        public void Test4()
        {
            int[,] a1 = { { 1, 5 }, { 2, 5 } };
            int[,] b1 = { { 1, 5 }, { 2, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<int[]> { new int[] { 1, 1 }, new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { 2, 2 } };

            var resultString = new List<string>();

            foreach (var item in result)
            {
                resultString.Add(item[0] + "" + item[1]);
            }

            var outputString = new List<string>();

            foreach (var item in output)
            {
                outputString.Add(item[0] + "" + item[1]);
            }

            CollectionAssert.AreEqual(outputString, resultString);
        }
    }
}