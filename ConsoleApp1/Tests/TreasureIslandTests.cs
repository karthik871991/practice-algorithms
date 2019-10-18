using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class TreasureIslandTests
    {
        [TestMethod]
        public void Test1()
        {
            int[,] input = { {1, 0, 0,},
                             {1, 0, 0,},
                             {1, 9, 1,}};

            var result = new TreasureIsland().removeObstacle(0,0,input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            int[,] input = { {1, 1, 1, 1},
                             {0, 0, 0, 1},
                             {1, 1, 1, 1},
                             {1, 1, 1, 1},
                             {1, 1, 1, 9}};

            var result = new TreasureIsland().removeObstacle(0,0,input);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Test3()
        {
            int[,] input = { {1, 1, 0, 1},
                             {0, 0, 0, 1},
                             {1, 1, 1, 1},
                             {1, 1, 1, 1},
                             {1, 1, 1, 9}};

            var result = new TreasureIsland().removeObstacle(0,0,input);

            Assert.AreEqual(-1, result);
        }
    }
}
