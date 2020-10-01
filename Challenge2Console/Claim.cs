using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Console
{
    public class Claim
    {
        public enum TypeOfClaim
        {
            Car = 1,
            Home,
            Theft
        }

        //properties
        public int ClaimID { get; set; }
        public TypeOfClaim ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        //empty constructor
        public Claim() { }

        //overloaded constructor
        public Claim(int claimID, TypeOfClaim claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
