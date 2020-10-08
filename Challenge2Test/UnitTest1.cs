using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge2Console;
using System.Collections;
using System.Collections.Generic;

namespace Challenge2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SeeAllClaims_ComparesAgainstTotal()
        {
            //Arrange
            ClaimRepository repo = new ClaimRepository();
            //Claim claim = new Claim();
            Queue<Claim> claimQ = new Queue<Claim>();
            int claimCount = claimQ.Count;

            //Act
            repo.SeeAllClaims();

            //Assert
            Assert.AreEqual(0, claimCount);
        }

        [TestMethod]
        public void AddNewClaim_MakeSureCountGoesUp()
        {
            //Arrange
            ClaimRepository repo = new ClaimRepository();
            Claim claim = new Claim();
            Queue<Claim> claimQ = new Queue<Claim>();

            //Act
            claim.ClaimID = 1;
            claim.ClaimType = (Claim.TypeOfClaim)1;
            claim.Description = "Car accident";
            claim.ClaimAmount = 1000.00m;
            claim.DateOfIncident = new DateTime(2020, 10, 4);
            claim.DateOfClaim = new DateTime(2020, 10, 7);
            claim.IsValid = true;
            repo.AddNewClaim();

            //Assert
            Assert.AreEqual(1, claimQ.Count);
        }

        [TestMethod]
        public void IsClaimValid_ReturnTrueOrFalse()
        {
            //Arrange
            ClaimRepository repo = new ClaimRepository();
            Claim claim = new Claim();
            Queue<Claim> claimQ = new Queue<Claim>();

            //Act
            claim.DateOfClaim = new DateTime(2020, 4, 12);
            repo.IsClaimValid();

            //Assert
            Assert.AreEqual(false, claim.IsValid);
        }
    }
}
