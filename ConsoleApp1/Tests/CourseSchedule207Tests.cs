using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CourseSchedule207Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[1][];
            input[0] = new int[] { 1, 0 };

            var result = new CourseSchedule207().CanFinish(2, input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[2][];
            input[0] = new int[] { 1, 0 };
            input[1] = new int[] { 0, 1 };

            var result = new CourseSchedule207().CanFinish(2, input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[3][];
            input[0] = new int[] { 1, 0 };
            input[1] = new int[] { 0, 2 };
            input[2] = new int[] { 2, 1 };

            var result = new CourseSchedule207().CanFinish(3, input);

            Assert.IsFalse(result);
        }
    }
}