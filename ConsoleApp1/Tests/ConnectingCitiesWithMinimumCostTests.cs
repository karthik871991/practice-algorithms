using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ConnectingCitiesWithMinimumCostTests
    {
        [TestMethod]
        public void Test1()
        {
            var result = new ConnectingCitiesWithMinimumCost().MinimumCost(3, new int[3][] { new int[] { 1, 2, 5 }, new int[] { 1, 3, 6 }, new int[] { 2, 3, 1 } });

            Assert.AreEqual(6, result);
        }
    }
}
