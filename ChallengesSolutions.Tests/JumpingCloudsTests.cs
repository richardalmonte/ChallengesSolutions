using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new int[] { 0, 1, 0, 0, 0, 1, 0 }, 3)]
        [DataRow(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
        [DataRow(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
        public void JumpingOnClouds_Test(int[] input, int expected)
        {
            var actual = Problems.JumpingOnClouds(input.ToList());

            Assert.AreEqual(expected, actual);
        }
    }
}