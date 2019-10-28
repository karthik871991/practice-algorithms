using AlgoPractice.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.TreeTests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tree = new BinarySearchTree().BuildTree(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            
        }
    }
}
