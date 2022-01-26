using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(7, 10, 4, 12, new int[] { 2, 3, -4 }, new int[] { 3, -2, -4 }, new int[] { 1, 2 })]
        [DataRow(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, new int[] { 1, 1 })]
        public void CountApplesAndOranges_Test(int s, int t, int a, int b, int[] apples, int[] oranges, int[] expected)
        {
            var actual = Problems.CountApplesAndOranges(s, t, a, b, apples.ToList(), oranges.ToList());

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}
