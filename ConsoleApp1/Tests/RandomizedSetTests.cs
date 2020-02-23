using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class RandomizedSetTests
    {
        //["RandomizedSet","insert","remove","insert","getRandom","remove","insert","getRandom"]
        //[[],[1],[2],[2],[],[1],[2],[]]

        [TestMethod]
        public void TestMethod1()
        {
            var sut = new RandomizedSet();
            var ch = new char();
            sut.Insert(1);
            sut.Remove(2);
            sut.Insert(2);
            var r = sut.GetRandom();
            sut.Remove(1);
            sut.Insert(2);
            r = sut.GetRandom();
        }
    }
}
