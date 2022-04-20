using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 2, 3, 5, 4, 6, 7, 8 }, "1")]
        [DataRow(new int[] { 4, 1, 2, 3 }, "Too chaotic")]
        [DataRow(new int[] { 2, 1, 5, 3, 4 }, "3")]
        //[DataRow(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }, "7")]
        public void MinimumBribes_Test(int[] input, string expected)
        {
            var result = Problems.MinimumBribes(input.ToList());

            Assert.AreEqual(expected, result);
        }


    }
}
