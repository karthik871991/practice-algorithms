using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PopulatingNextRightPointersinEachNodeII117Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new SampleTreeNode(1);
            node.left = new SampleTreeNode(2);
            node.right = new SampleTreeNode(3);
            node.left.left = new SampleTreeNode(4);
            node.left.right = new SampleTreeNode(5);
            node.right.left = null;
            node.right.right = new SampleTreeNode(7);

            var sut = new PopulatingNextRightPointersinEachNodeII117().Connect(node);

            Assert.IsNull(sut.next);
            Assert.AreEqual(sut.left.next.val, 3);
            Assert.AreEqual(sut.left.left.next.val, 5);
            Assert.AreEqual(sut.left.right.next.val, 7);
        }
    }
}
