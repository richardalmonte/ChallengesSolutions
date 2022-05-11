using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod]
        [DataRow(new int[] { -4, 3, -9, 0, 4, 1 }, "0.500000;0.333333;0.166667")]
        [DataRow(new int[] { 1, 1, 0, -1, -1 }, "0.400000;0.400000;0.200000")]
        public void PlusMinus_Test(int[] input, string expected)
        {
            var result = Problems.PlusMinus(input);

            Assert.AreEqual(expected, result);
        }
    }
}