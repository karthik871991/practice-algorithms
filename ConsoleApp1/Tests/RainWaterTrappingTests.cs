using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class RainWaterTrappingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var result = new RainWaterTrapping().Trap(input);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 0, 1, 2, 3, 1, 3, 2, 1, 0 };
            var result = new RainWaterTrapping().Trap(input);

            Assert.AreEqual(6, result);
        }
    }
}
