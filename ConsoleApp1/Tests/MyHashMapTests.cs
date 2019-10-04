using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MyHashMapTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var map = new MyHashMap<int ,int>();
            map.Put(1, 1);
            map.Put(2, 2);
            map.Put(3, 3);
            map.Put(1, 1);
            map.Put(1, 5);

            Assert.AreEqual(5, map.Get(1));

        }
    }
}
