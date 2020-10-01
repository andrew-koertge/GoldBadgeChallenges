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

        public void BuildQueue(bool isClaimValid)
        {
            Queue<int> claimIDQ = new Queue<int>();
            claimIDQ.Enqueue(claim.ClaimID);

            /*
            Queue<string> claimTypeQ = new Queue<string>();
            claimTypeQ.Enqueue(claim.ClaimType);
            */

            Queue<decimal> claimAmountQ = new Queue<decimal>();
            claimAmountQ.Enqueue(claim.ClaimAmount);

            Queue<DateTime> dateQ = new Queue<DateTime>();
            dateQ.Enqueue(claim.DateOfClaim);
            dateQ.Enqueue(claim.DateOfIncident);

            Queue<string> claimStringQ = new Queue<string>();
            claimStringQ.Enqueue(claim.Description);

            Queue<bool> isValidQ = new Queue<bool>();
            isValidQ.Enqueue(isClaimValid);
        }

        public string ReturnBuiltQueue(Queue<int> claimIDQ)
        {

        }
    }
}
