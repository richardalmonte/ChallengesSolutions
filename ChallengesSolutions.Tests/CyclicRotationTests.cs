using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [DataRow(new int[] { 3 }, 5, new int[] { 3 })]
        public void CyclicRotation_Test(int[] input, int steps, int[] expected)
        {
            var actual = Problems.CyclicRotation(input, steps);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}