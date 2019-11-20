using AlgoPractice.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.TreeTests
{
    [TestClass]
    public class SearchBSTForTargetTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new SearchBSTForTarget().FindTarget(
                new TreeNode 
                { 
                    val = 5, 
                    left = new TreeNode 
                    { 
                        val = 3 , 
                        left = new TreeNode 
                        { 
                            val = 2
                        }, 
                        right = new TreeNode
                        {
                            val = 4
                        }
                    },
                    right = new TreeNode
                    {
                        val = 6,
                        right = new TreeNode
                        {
                            val = 7
                        }
                    }
                }, 9);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new SearchBSTForTarget().FindTarget(
                new TreeNode
                {
                    val = 1
                }, 2);

            Assert.IsTrue(result);
        }
    }
}
