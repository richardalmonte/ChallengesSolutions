using ChallengesSolutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        public void MinPiecesTest()
        {
            int[] original = new int[] { 1, 4, 3, 2, };
            int[] desired = new int[] { 1, 2, 4, 3, };

            var result = Problems.MinPieces(original, desired);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Test()
        {
            var result = Problems.GetSum();
            Assert.AreEqual(result, 6);
        }
    }
}