using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class GameOfLifeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[4][];
            input[0] = new int[] { 0, 1, 0 };
            input[1] = new int[] { 0, 0, 1 };
            input[2] = new int[] { 1, 1, 1 };
            input[3] = new int[] { 0, 0, 0 };

            new GameOfLife289().GameOfLife(input);
        }
    }
}