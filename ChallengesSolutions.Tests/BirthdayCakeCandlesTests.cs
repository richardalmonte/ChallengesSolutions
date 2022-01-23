using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    [TestClass()]
    public partial class ProblemsTests
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

    }
}