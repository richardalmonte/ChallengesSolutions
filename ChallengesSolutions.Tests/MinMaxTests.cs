using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new int[] { 426980153, 354802167, 142980735, 968217435, 734892650 }, 1659655705, 2484892405)]
        [DataRow(new int[] { 7, 69, 2, 221, 8974 }, 299, 9271)]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 10, 14)]
        public void MiniMaxSum_Test(int[] input, long expectedMin, long expectedMax)
        {
            var result = Problems.MiniMaxSum(input);
            
            CollectionAssert.AreEqual(new long[] { expectedMin, expectedMax }, result);
        }
    }
}