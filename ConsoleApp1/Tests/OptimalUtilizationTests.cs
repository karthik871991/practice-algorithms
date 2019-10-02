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
            List<List<int>> a1 = new List<List<int>> {  new List<int> { 1, 3 }, new List<int> { 2, 5 }, new List<int> { 3, 7 }, new List<int> { 4, 10 } };
            List<List<int>> b1 = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<List<int>> { new List<int> { 2, 4 }, new List<int> { 3, 2 } };

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
            List<List<int>> a1 = new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 2, 5 }, new List<int> { 3, 7 }, new List<int> { 4, 10 }, new List<int> { 5, 7 } };
            List<List<int>> b1 = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<List<int>> { new List<int> { 2, 4 }, new List<int> { 3, 2 }, new List<int> { 5, 2 } };

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
            List<List<int>> a1 = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 4 }, new List<int> { 3, 6 } };
            List<List<int>> b1 = new List<List<int>> { new List<int> { 1, 2 } };
            int target = 7;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<List<int>> { new List<int> { 2, 1 } };

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
            List<List<int>> a1 = new List<List<int>> { new List<int> { 1, 5 }, new List<int> { 2, 5 } };
            List<List<int>> b1 = new List<List<int>> { new List<int> { 1, 5 }, new List<int> { 2, 5 } };
            int target = 10;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 1, 2 }, new List<int> { 2, 1 }, new List<int> { 2, 2 } };

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
        public void Test5()
        {
            List<List<int>> a1 = new List<List<int>> { new List<int> { 1, 8 }, new List<int> { 2, 7 }, new List<int> { 3, 14 } };
            List<List<int>> b1 = new List<List<int>> { new List<int> { 1, 5 }, new List<int> { 2, 10 }, new List<int> { 3, 14 } };
            int target = 20;
            var result = new OptimalUtilization().GetOptimalUtilization(a1, b1, target);

            var output = new List<List<int>> { new List<int> { 3, 1 } };

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