using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{

    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(100, "DUDUUUUUUUUDUDDUUDUUDDDUUDDDDDUUDUUUUDDDUUUUUUUDDUDUDUUUDDDDUUDDDUDDDDUUDDUDDUUUDUUUDUUDUDUDDDDDDDDD", 2)]
        [DataRow(12, "DDUUDDUDUUUD", 2)]
        [DataRow(10, "UDUUUDUDDD", 0)]
        [DataRow(8, "UDDDUDUU", 1)]
        public void CountingValleys_Test(int steps, string path, int expected)
        {
            var result = Problems.CountingValleys(steps, path);

            Assert.AreEqual(expected, result);
        }
    }
}
