using ChallengesSolutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengesSolutions
{
    [TestClass()]
    public class Prime_ProblemsTests
    {
        PrimeProblems sut;

        [TestInitialize]
        public void Initialize()
        {
            sut = new PrimeProblems();
        }


        [TestMethod]
        [DynamicData(nameof(TestData), DynamicDataSourceType.Property)]
        public void IsPrime_Test(int number, bool expected)
        {
            var result = sut.IsPrime_Simple(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Timeout(10)]
        [DynamicData(nameof(TestData), DynamicDataSourceType.Property)]
        public void IsPrime_Test2(int number, bool expected)
        {
            var result = sut.IsPrime_Sqrt(number);
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 1, false };
                yield return new object[] { 2, true };
                yield return new object[] { 3, true };
                yield return new object[] { 4, false };
                yield return new object[] { 5, true };
                yield return new object[] { 6, false };
                yield return new object[] { 7, true };
                yield return new object[] { 8, false };
                yield return new object[] { 9, false };
                yield return new object[] { 10, false };
                yield return new object[] { 11, true };
                yield return new object[] { 12, false };
                yield return new object[] { 13, true };
                yield return new object[] { 14, false };
                yield return new object[] { 15, false };
                yield return new object[] { 15485863, true };
            }
        }
    }
}