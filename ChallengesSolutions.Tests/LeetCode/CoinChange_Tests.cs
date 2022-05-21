using ChallengesSolutions.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions.Tests.LeetCode
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 5 }, 11, 3)]
        [DataRow(new int[] { 186, 419, 83, 408 }, 6249, 20)]
        [DataRow(new int[] { 2 }, 3, -1)]
        public void CoinChange_Test_Copilot_OK(int[] input, int target, int expected)
        {
            var sut = new CoinChangeProblem();
            var result = sut.CoinChange_Copilot(input, target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        // [DataRow(new int[] { 1, 2, 5 }, 11, 3)]
        [DataRow(new int[] { 186, 419, 83, 408 }, 6249, 20)]
        public void CoinChange_Test_Mine_OK(int[] input, int target, int expected)
        {
            var sut = new CoinChangeProblem();
            var result = sut.CoinChage_Mine(input, target);
            Assert.AreEqual(expected, result);
        }
    }
}