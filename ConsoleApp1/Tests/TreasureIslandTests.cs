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
            char[,] input = {{'O', 'O', 'O', 'O'},
                             {'D', 'O', 'D', 'O'},
                             {'O', 'O', 'O', 'O'},
                             {'X', 'D', 'D', 'O'}};

            var result = new TreasureIsland().MinSteps(input);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test2()
        {
            char[,] input = {{'O', 'O', 'O', 'O'},
                             {'D', 'D', 'D', 'O'},
                             {'O', 'O', 'O', 'o'},
                             {'o', 'D', 'D', 'D'},
                             {'o', 'o', 'o', 'X'}};

            var result = new TreasureIsland().MinSteps(input);

            Assert.AreEqual(13, result);
        }
    }
}
