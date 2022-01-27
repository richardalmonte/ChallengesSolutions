using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(2, 1, 1, 2, "YES")]
        [DataRow(0, 3, 4, 2, "YES")]
        [DataRow(0, 2, 5, 3, "NO")]
        public void Kangaroo_Test(int x1, int v1, int x2, int v2, string expected)
        {
            var actual = Problems.Kangaroo(x1, v1, x2, v2);

            Assert.AreEqual(expected, actual);
        }
    }
}
