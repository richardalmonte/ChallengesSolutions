using ChallengesSolutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesSolutions
{
    [TestClass()]
    public class ProblemsTests
    {

        [TestMethod()]

        [DataRow(new int[] {9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999,
                            9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999, 9999999}, 20)]
        [DataRow(new int[] { 4, 4, 1, 3 }, 2)]
        [DataRow(new int[] { 3, 2, 1, 3 }, 2)]
        [DataRow(new int[] { 18, 90, 90, 13, 90, 75, 90, 8, 90, 43 }, 5)]
        [DataRow(new int[] { }, 0)]
        [DataRow(null, 0)]
        [Timeout(350)]
        public void BirthdayCakeCandles_Test(int[] input, int expected)
        {
            var result = Problems.BirthdayCakeCandles(input?.ToList());
            Assert.AreEqual(expected, result);
        }


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

        [TestMethod()]
        [DataRow(new int[] { 426980153, 354802167, 142980735, 968217435, 734892650 }, 1659655705, 2484892405)]
        [DataRow(new int[] { 7, 69, 2, 221, 8974 }, 299, 9271)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 10, 14)]
        public void MiniMaxSum_Test(int[] input, long expectedMin, long expectedMax)
        {
            var result = Problems.MiniMaxSum(input);
            Assert.AreEqual(expectedMin, result[0]);
            Assert.AreEqual(expectedMax, result[1]);
        }
    }
}