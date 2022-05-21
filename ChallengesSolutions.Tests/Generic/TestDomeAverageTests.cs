using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        [TestMethod]
        [DataRow(2, 2, 2)]
        [DataRow(2, 1, 1)]
        public void Average_Test(int a, int b, int expected)
        {
            var result = Problems.Average(a, b);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void FindTwoSum_Test()
        {
            List<int> list = new List<int> { 3, 1, 5, 7, 5, 9 };

            int sum = 10;
            var expected = new List<Tuple<int, int>>() {
                new Tuple<int, int>(0, 3),
                new Tuple<int, int>(1, 5),
                new Tuple<int, int>(2, 4),
                new Tuple<int, int>(3, 0),
                new Tuple<int, int>(5, 1),
                new Tuple<int, int>(1, 5)
            };

            var result = Problems.FindTwoSum(list, sum);

            Assert.IsNotNull(result);
            CollectionAssert.Contains(expected, result);
        }
    }
}