using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {

        [TestMethod()]
        [DataRow(new object[] { new int[] { -1, 1, -7, -8 }, new int[] { -10, -8, -5, -2 }, new int[] { 0, 9, 7, -1 }, new int[] { 4, 4, -2, 1 } }, 1)]
        [DataRow(new object[] { new int[] { 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 } }, 15)]
        public void DiagonalDifference_Bitwise_Test(object[] input, int expected)
        {
            var result = Problems.DiagonalDifference_Bitwise(input.Select(x => ((int[])x).ToList()).ToList());

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [DataRow(new object[] { new int[] { -1, 1, -7, -8 }, new int[] { -10, -8, -5, -2 }, new int[] { 0, 9, 7, -1 }, new int[] { 4, 4, -2, 1 } }, 1)]
        [DataRow(new object[] { new int[] { 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 } }, 15)]
        public void DiagonalDifference_Test(object[] input, int expected)
        {
            var result = Problems.DiagonalDifference_Accepted(input.Select(x => ((int[])x).ToList()).ToList());

            Assert.AreEqual(expected, result);
        }

    }
}