using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Console
{
    public class ClaimRepository
    {
        Claim claim = new Claim();

        //See all claims
        public void SeeAllClaims()
        {
            Queue<Claim> claims = new Queue<Claim>();
            foreach (Object obj in claims)
            {
                Console.WriteLine(obj);
            }
        }

        //Take care of next claim
        public void TakeCareOfNextClaim(bool nextClaim)
        {
            if (nextClaim == true)
            {
                Queue<Claim> claims = new Queue<Claim>();
                claims.Dequeue();
            }
        }

        //Add a new claim
        public void AddNewClaim()
        {
            Queue<Claim> claims = new Queue<Claim>();
            Claim claim = new Claim();

            Console.WriteLine("Enter the claim ID: ");
            int claimID = Int32.Parse(Console.ReadLine());
            claim.ClaimID = claimID;

            Console.WriteLine("Enter the claim type: ");
            int claimType = Int32.Parse(Console.ReadLine());
            Claim.TypeOfClaim claimType1 = (Claim.TypeOfClaim)claimType;
            claim.ClaimType = claimType1;

            Console.WriteLine("Enter a claim description");
            string claimDescription = Console.ReadLine();
            claim.Description = claimDescription;

            Console.WriteLine("Amount of damage");
            int claimAmount = Int32.Parse(Console.ReadLine());
            claim.ClaimAmount = claimAmount;

            Console.WriteLine("Date of Incident");
            DateTime incidentDate = DateTime.Parse(Console.ReadLine());
            claim.DateOfIncident = incidentDate;

            Console.WriteLine("Date of Claim");
            DateTime claimDate = DateTime.Parse(Console.ReadLine());
            claim.DateOfClaim = claimDate;

            bool valid = IsClaimValid();
            if (valid == true)
            {
                Console.WriteLine("This claim is valid.");
            }
            else
            {
                Console.WriteLine("This claim is not valid.");
            }
        }

        //determines if claim is valid
        public bool IsClaimValid()
        {
            DateTime claimDate = claim.DateOfClaim;
            bool isClaimValid = claim.IsValid;

            //checks if date of claim is up to 30 days out, it's a valid claim if true
            if ((claimDate - DateTime.Now).TotalDays <= 30)
            {
                isClaimValid = true;
            }
            else
            {
                isClaimValid = false;
            }
            return isClaimValid;
        }

        //Helper method
        public Queue<Claim> BuildQueue(bool isClaimValid)
        {
            if (isClaimValid == true)
            {
                Queue<Claim> claimQ = new Queue<Claim>();
                return claimQ;
            }
            return null;
        }
    }
}
