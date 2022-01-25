using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod()]
        [DataRow(new object[] {
            new int[] { -9, -9, -9, 1,1,1 },
            new int[] { 0,-9,0,4,3,2},
            new int[] { -9,-9,-9,1,2,3 },
            new int[] {0,0,8,6,6,0 } ,
            new int[] {0,0,0,-2,0,0 },
            new int[] {0,0,1,2,4,0 }
        }, 28)]
        [DataRow(new object[] {
            new int[] { 1,1,1,0,0,0 },
            new int[] { 0,1,0,0,0,0 },
            new int[] { 1,1,1,0,0,0 },
            new int[] { 0,0,2,4,4,0} ,
            new int[] { 0,0,0,2,0,0 },
            new int[] { 0,0,1,2,4,0 }
        }, 10)]
        [DataRow(new object[]
        {
            new int[] { -1,-1,0,-9,-2,-2 },
            new int[] {-2,-1,-6,-8,-2,-5 },
            new int[] {-1,-1,-1,-2,-3,-4 },
            new int[] {-1,-9,-2,-4,-4,-5 },
            new int[] {-7,-3,-3,-2,-9,-9 },
            new int[] {-1,-3,-1,-2,-4,-5 }
        }, -6)]
        public void HourglassSumm_Test(object[] input, int expected)
        {
            var result = Problems.HourglassSum(input.Select(x => ((int[])x).ToList()).ToList());

            Assert.AreEqual(expected, result);
        }


    }
}
