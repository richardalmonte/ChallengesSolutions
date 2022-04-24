using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new int[] { 73, 67, 38, 33 }, new int[] { 75, 67, 40, 33 })]
        [DataRow(new int[] { 37, 38 }, new int[] { 37, 40 })]
        [DataRow(new int[] { 84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2, 29, 53, 61, 40, 14, 4, 29, 98, 37, 23, 46, 9, 79, 62, 20, 38, 51, 99, 59, 47, 4, 86, 61, 68, 17, 45, 6, 1, 95, 95 },
                 new int[] { 85, 95, 21, 0, 18, 100, 18, 62, 30, 61, 55, 0, 45, 2, 29, 55, 61, 40, 14, 4, 29, 100, 37, 23, 46, 9, 80, 62, 20, 40, 51, 100, 60, 47, 4, 86, 61, 70, 17, 45, 6, 1, 95, 95 })]
        [DataRow(new int[] { 80, 96, 18, 73, 78, 60, 60, 15, 45, 15, 10, 5, 46, 87, 33, 60, 14, 71, 65, 2, 5, 97, 0 },
                 new int[] { 80, 96, 18, 75, 80, 60, 60, 15, 45, 15, 10, 5, 46, 87, 33, 60, 14, 71, 65, 2, 5, 97, 0 })]
        public void GradingStudents_Test(int[] input, int[] expected)
        {
            var actual = Problems.GradingStudents(input.ToList());

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
