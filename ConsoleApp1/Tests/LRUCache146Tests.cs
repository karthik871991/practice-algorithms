using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class LRUCache146Tests
    {
        [TestMethod]
        public void LRUTests()
        {
            var cache = new LRUCache(20);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);
            cache.Put(4, 4);
            cache.Put(5, 5);
            cache.Put(6, 6);

            var head = cache.GetHead();
            int count = 6;

            while (head != null && head.Previous != null)
            {
                Assert.AreEqual(head.Value, count);
                count--;
                head = head.Previous;
            }

            var value = cache.Get(1);

            Assert.AreEqual(1, value);

            var list = new List<int> { 2, 3, 4, 5, 6, 1 };

            var head1 = cache.GetHead();
            int count1 = list.Count - 1;

            while (head1 != null && count1 < list.Count && head1.Previous != null)
            {
                Assert.AreEqual(head1.Value, list[count1]);
                count1--;
                head1 = head1.Previous;
            }


        }
    }
}
