using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [Timeout(100)]
        public void MissingInteger_My_Test(int[] input, int expected)
        {
            var actual = Problems.MissingInteger_My(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [Timeout(100)]
        public void MissingInteger_Aim100_Test(int[] input, int expected)
        {
            var actual = Problems.MissingInteger_Aim100(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [Timeout(100)]
        public void MissingInteger_Medium_Test(int[] input, int expected)
        {
            var actual = Problems.MissingInteger_Medium(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [Timeout(100)]
        public void MissingInteger_SimpleCostly_Test(int[] input, int expected)
        {
            var actual = Problems.MissingInteger_SimpleCostly(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [DataRow(new int[] { 1, 2, 3 }, 4)]
        [DataRow(new int[] { -1, -3 }, 1)]
        [Timeout(100)]
        public void MissingInteger_StackOverflow_Test(int[] input, int expected)
        {
            var actual = Problems.MissingInteger_StackOverflow(input);
            Assert.AreEqual(expected, actual);
        }
    }
}