using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewZen.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewZen.Tests
{
    [TestClass()]
    public class BusinessLogicTests
    {
        [TestMethod()]
        public void ValidateBusinessEntityTest()
        {
            //Arrange
            Program.BusinessLogic businessLogic = new Program.BusinessLogic();
            string businessEntity = "";
            string expected = "";
            string actual = "";
            //Act
            actual = businessLogic.ValidateBusinessEntity();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}