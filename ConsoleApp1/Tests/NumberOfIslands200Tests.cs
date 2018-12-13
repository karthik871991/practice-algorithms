using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class NumberOfIslands200Tests
    {
        [TestMethod]
        public void NumIslands()
        {
            var islands = new NumberOfIslands200();

            char[,] grid = new char[4, 5];
            grid[0, 0] = '1';
            grid[0, 1] = '1';
            grid[0, 2] = '0';
            grid[0, 3] = '0';
            grid[0, 4] = '0';
            grid[1, 0] = '1';
            grid[1, 1] = '1';
            grid[1, 2] = '0';
            grid[1, 3] = '0';
            grid[1, 4] = '0';
            grid[2, 0] = '0';
            grid[2, 1] = '0';
            grid[2, 2] = '1';
            grid[2, 3] = '0';
            grid[2, 4] = '0';
            grid[3, 0] = '0';
            grid[3, 1] = '0';
            grid[3, 2] = '0';
            grid[3, 3] = '1';
            grid[3, 4] = '1';

            var result = islands.NumIslands(grid);

            Assert.AreEqual(3, result);
        }
    }
}
