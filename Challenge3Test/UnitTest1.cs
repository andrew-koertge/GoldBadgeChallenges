using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge3Console;
using System.Collections.Generic;
using Challenge3;

namespace Challenge3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewOuting_ReturnsCorrectValue()
        {
            //Arrange
            OutingRepository repo = new OutingRepository();
            int outingTotal = 0;
            //Act
            repo.AddNewOuting();
            //Assert
            Assert.AreEqual(outingTotal, 1);
        }
    }
}
