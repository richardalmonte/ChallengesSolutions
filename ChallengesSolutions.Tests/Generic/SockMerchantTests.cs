using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
        [DataRow(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        public void SockMerchant_Test(int[] input, int expected)
        {
            var result = Problems.SockMerchant(input);

            Assert.AreEqual(expected, result);
        }
    }
}
