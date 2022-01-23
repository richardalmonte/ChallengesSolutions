using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new string[] { "     #", "    ##","   ###", "  ####", " #####", "######" }, 6)]
        public void Staircase_Test(string[] expected, int input)
        {
            var result = Problems.Staircase(input);

            Assert.AreEqual(string.Join("\n", expected), string.Join("\n", result));
        }
    }
}
