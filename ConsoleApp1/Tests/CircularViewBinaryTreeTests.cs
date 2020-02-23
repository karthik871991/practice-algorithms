using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class CircularViewBinaryTreeTests : CircularViewBinaryTree
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 4
                    },
                    right = new TreeNode
                    {
                        val = 5
                    }
                },
                right = new TreeNode
                {
                    val = 3,
                    left = new TreeNode
                    {
                        val = 6
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }
                }
            };
            var list = new CircularViewBinaryTree().BoundaryOfBinaryTree(node).ToList();
            CollectionAssert.AreEqual(list, new List<int> { 1, 2, 4, 5, 6, 7, 3 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 3
                    },
                    right = new TreeNode
                    {
                        val = 4
                    }
                }
            };
            var list = new CircularViewBinaryTree().BoundaryOfBinaryTree(node).ToList();
            CollectionAssert.AreEqual(list, new List<int> { 1, 3, 4, 2 });
        }
    }
}
