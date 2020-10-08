using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Komodo Insurance. Please choose from the following options: /n" +
                              "1. See all claims \n" +
                              "2. Take care of next claim \n" +
                              "3. Enter a new claim");

            string choice = Console.ReadLine();
            ClaimRepository repo = new ClaimRepository();
            switch (choice)
            {
                case "1":
                    repo.SeeAllClaims();
                    break;
                case "2":
                    Queue<Claim> claim = new Queue<Claim>();
                    claim.Peek();
                    Console.WriteLine("Do you want to deal with this claim now? (y/n)");
                    string claimChoice = Console.ReadLine();
                    if (claimChoice == "y")
                    {
                        repo.TakeCareOfNextClaim(true);
                    }
                    else
                    {
                        Console.WriteLine("Returning to main menu.");
                        Console.ReadLine();
                        Run();
                    }
                    break;
                case "3":
                    repo.AddNewClaim();
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    Console.ReadLine();
                    Run();
                    break;
            }
        }
    }
}
