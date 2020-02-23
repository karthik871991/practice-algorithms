using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MergeKSortedListTests : MergeKSortedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n1 = new ListNode(1);
            n1.next = new ListNode(4);
            n1.next.next = new ListNode(5);

            var n2 = new ListNode(1);
            n2.next = new ListNode(3);
            n2.next.next = new ListNode(4);

            var n3 = new ListNode(2);
            n3.next = new ListNode(6);
            var input = new ListNode[3] { n1, n2, n3 };

            var sut = new MergeKSortedList();

            var result = sut.MergeKLists(input);

            var expected = new List<int> { 1, 1, 2, 3, 4, 4, 5, 6 };
            int i = 0;
            while (result != null && i < expected.Count)
            {
                Assert.AreEqual(result.val, expected[i++]);
                result = result.next;
            }
        }
    }
}
