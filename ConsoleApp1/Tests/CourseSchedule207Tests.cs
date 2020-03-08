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

        [TestMethod]
        public void TestMethod4()
        {
            var input = new int[3][];
            input[0] = new int[] { 1, 0 };
            input[1] = new int[] { 2, 1 };
            input[2] = new int[] { 3, 2 };

            var result = new CourseSchedule207().CanFinish(3, input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var input = new int[5][];
            input[0] = new int[] { 1, 0 };
            input[1] = new int[] { 2, 1 };
            input[2] = new int[] { 3, 2 };
            input[3] = new int[] { 5, 4 };
            input[4] = new int[] { 6, 5 };

            var result = new CourseSchedule207().CanFinish(3, input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var input = new int[2][];
            input[0] = new int[] { 2, 1 };
            input[1] = new int[] { 1, 0 };

            var result = new CourseSchedule207().CanFinish(3, input);

            Assert.IsTrue(result);
        }
    }
}