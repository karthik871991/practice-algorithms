using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class FindMedianfromDataStreamTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new MedianFinder();

            sut.AddNum(1);
            sut.AddNum(2);
            Assert.AreEqual(1.5, sut.FindMedian());
            sut.AddNum(3);
            Assert.AreEqual(2.0, sut.FindMedian());
            sut.AddNum(4);
            sut.AddNum(5);
            Assert.AreEqual(3.0, sut.FindMedian());
            sut.AddNum(6);
            Assert.AreEqual(3.5, sut.FindMedian());
            sut.AddNum(6);
            Assert.AreEqual(4.0, sut.FindMedian());
            sut.AddNum(6);
            Assert.AreEqual(4.5, sut.FindMedian());
        }
    }
}
