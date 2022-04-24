using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesSolutions
{
    public partial class ProblemsTests
    {
        //[TestMethod()]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "banana", "orange", "banana", "apple", "apple" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "banana", "apple", "banana", "orange", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "apple,apple,banana" }, new string[] { "apple", "apple", "apple", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "anything,apple", "banana,anything,banana" }, new string[] { "orange", "grapes", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "apple,orange", "orange,banana,orange" }, new string[] { "apple", "orange", "banana", "orange", "orange", "banana", "orange", "grape" }, true)]
        [DataRow(new string[] { "anything,anything,anything,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" }, true)]
        public void AmazonFresh_Test(string[] codeListInput, string[] shoppingCart, bool expected)
        {
            var actual = Problems.AmazonPromotionWinner(codeListInput.ToList(), shoppingCart.ToList());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "banana", "orange", "banana", "apple", "apple" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "banana", "apple", "banana", "orange", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "apple,apple,banana" }, new string[] { "apple", "apple", "apple", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "anything,apple", "banana,anything,banana" }, new string[] { "orange", "grapes", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "apple,orange", "orange,banana,orange" }, new string[] { "apple", "orange", "banana", "orange", "orange", "banana", "orange", "grape" }, true)]
        [DataRow(new string[] { "anything,anything,anything,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" }, true)]
        public void WinPrize_Test(string[] codeListInput, string[] shoppingCart, bool expected)
        {
            List<string[]> codeList = new List<string[]>();

            foreach (var code in codeListInput)
            {
                codeList.Add(code.Split(',').ToArray());
            }

            var actual = Problems.WinPrize(codeList.ToArray(), shoppingCart.ToArray());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "banana", "orange", "banana", "apple", "apple" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "banana", "apple", "banana", "orange", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "apple,apple,banana" }, new string[] { "apple", "apple", "apple", "banana" }, false)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "apple", "banana", "orange", "banana" }, true)]
        [DataRow(new string[] { "apple,apple", "banana,anything,banana" }, new string[] { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "anything,apple", "banana,anything,banana" }, new string[] { "orange", "grapes", "apple", "orange", "orange", "banana", "apple", "banana", "banana" }, true)]
        [DataRow(new string[] { "apple,orange", "orange,banana,orange" }, new string[] { "apple", "orange", "banana", "orange", "orange", "banana", "orange", "grape" }, true)]
        [DataRow(new string[] { "anything,anything,anything,apple", "banana,anything,banana" }, new string[] { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" }, true)]
        public void IsPromotionWinner_Test(string[] codeListInput, string[] shoppingCart, bool expected)
        {
            List<string[]> codeList = new List<string[]>();

            foreach (var code in codeListInput)
            {
                codeList.Add(code.Split(',').ToArray());
            }
            var actual = Problems.IsPromotionWinner(codeList.ToArray(), shoppingCart.ToArray());

            Assert.AreEqual(expected, actual);
        }
    }
}
