using AlgoPractice;
using AlgoPractice.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MaximumLevelSumofaBinaryTreeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new TreeNode { val = 1, left = new TreeNode { val = 7, left = new TreeNode { val = 7 }, right = new TreeNode { val = -8 } }, right = new TreeNode { val = 0 } };
            var result = new MaximumLevelSumofaBinaryTree().MaxLevelSum(node);

            Assert.AreEqual(2, result);
        }

    }
}
