﻿using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PrisonCellsAfterNDays957Tests
    {
        [TestMethod]
        public void PrisonCellsTests()
        {
            var cells = new PrisonCellsAfterNDays();

            var intArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            var n = 20;

            var result = cells.PrisonAfterNDays(intArray, n);

            CollectionAssert.AreEquivalent(new int[] { 0, 1, 1, 0, 0, 1, 1, 0 }, result);
        }


        [TestMethod]
        public void PrisonCellsTestsHigherInput()
        {
            var cells = new PrisonCellsAfterNDays();

            var intArray = new int[] { 1, 0, 0, 1, 0, 0, 1, 0 };
            var n = 1000000000;

            var result = cells.PrisonAfterNDays(intArray, n);

            CollectionAssert.AreEquivalent(new int[] { 0, 0, 1, 1, 1, 1, 1, 0 }, result);
        }
    }
}
