using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 5, 1, 2, 3, 4 })]
        [DataRow(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public void RotLeft_Test(int[] input, int steps, int[] expected)
        {
            var actual = Problems.RotLeft(input.ToList(), steps);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}