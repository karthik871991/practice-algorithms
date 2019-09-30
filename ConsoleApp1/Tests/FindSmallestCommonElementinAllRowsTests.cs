using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FindSmallestCommonElementinAllRowsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 }, new int[] { 6, 7, 8, 9, 10 } };

            var result = new FindSmallestCommonElementinAllRows().SmallestCommonElement(input);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[][] { new int[] { 1, 2, 3, 4, 5 },new int[] { 2, 4, 5, 8, 10 },
            new int[] { 3, 5, 7, 9, 11 },new int[]{1, 3, 5, 7, 9 } };

            var result = new FindSmallestCommonElementinAllRows().SmallestCommonElement(input);

            Assert.AreEqual(5, result);
        }
    }
}