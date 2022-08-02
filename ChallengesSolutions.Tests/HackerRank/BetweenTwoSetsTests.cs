using System.Linq;
using ChallengesSolutions.HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengesSolutions.Tests.HackerRank;

[TestClass]
public class BetweenTwoSetsTests
{
    private BetweenTwoSets sut;

    [TestInitialize]
    public void Setup()
    {
        sut = new BetweenTwoSets();
    }

    [TestMethod]
    [DataRow(new int[] { 2, 4 }, new int[] { 16, 32, 96 }, 3)]
    [DataRow(new int[] { 3, 4 }, new int[] { 24, 48 }, 2)]
    public void BetweenTwoSets_Test(int[] inputA, int[] inputB, int expected)
    {
        var result = sut.GetTotalX(inputA.ToList(), inputB.ToList());
        Assert.AreEqual(expected, result);
    }
}