using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengesSolutions.DevSkiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewZen.Tests
{
    [TestClass()]
    public class NumbersExceptionTests
    {
        [TestMethod()]
        public void RemoveAndPrintNumbersTest()
        {
            var sut = new NumbersException();

            
            Assert.ThrowsException<InvalidOperationException>(sut.RemoveAndPrintNumbers);

        }
    }
}