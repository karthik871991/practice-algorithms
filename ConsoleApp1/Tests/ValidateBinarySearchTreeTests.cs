using AlgoPractice;
using AlgoPractice.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ValidateBinarySearchTreeTests : ValidateBinarySearchTree
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new TreeNode { val = 2, left = new TreeNode { val = 1 }, right = new TreeNode { val = 3 } };
            var result = new ValidateBinarySearchTree().IsValidBST(node);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = new TreeNode { val = 2147483647 };
            var result = new ValidateBinarySearchTree().IsValidBST(node);

            Assert.IsTrue(result);
        }

    }
}
