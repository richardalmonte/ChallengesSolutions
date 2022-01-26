using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(9, 2)]
        [DataRow(20, 1)]
        [DataRow(30, 0)]
        [DataRow(15, 0)]
        [DataRow(1041, 5)]
        public void BinaryGap_Test(int input, int expected)
        {
            var actual = Problems.BinaryGap(input);
            Assert.AreEqual(expected, actual);
        }
    }
}