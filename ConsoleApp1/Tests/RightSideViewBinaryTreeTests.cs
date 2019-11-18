using AlgoPractice;
using AlgoPractice.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class RightSideViewBinaryTreeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new TreeNode { val = 1, left = new TreeNode { val = 2 }, right = new TreeNode { val = 3 } };
            var result = new RightSideViewBinaryTree().RightSideView(node);
            IList<int> expResult = new List<int> { 1, 3 };

            CollectionAssert.AreEqual(expResult.ToList(), result.ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = new TreeNode { val = 1, left = new TreeNode { val = 2 }, right = new TreeNode { val = 3, right = new TreeNode { val = 4 } } };
            var result = new RightSideViewBinaryTree().RightSideView(node);
            IList<int> expResult = new List<int> { 1, 3, 4 };

            CollectionAssert.AreEqual(expResult.ToList(), result.ToList());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var node = new TreeNode { val = 1, left = new TreeNode { val = 2, left = new TreeNode { val = 6, left = new TreeNode { val = 7 } } } };
            var result = new RightSideViewBinaryTree().RightSideView(node);
            IList<int> expResult = new List<int> { 1, 2, 6, 7 };

            CollectionAssert.AreEqual(expResult.ToList(), result.ToList());
        }

    }
}
