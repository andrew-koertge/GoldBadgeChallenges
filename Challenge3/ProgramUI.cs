using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class ProgramUI
    {
        public void Run()
        {
            int golfOuting = 0;
            int bowlOuting = 0;
            int amusementOuting = 0;
            int concertOuting = 0;

            OutingRepository repo = new OutingRepository();
            Console.WriteLine("Komodo outings calculator. Please select from the following options: \n" +
                              "1. List all outings \n" +
                              "2. Add an outing to a list \n" +
                              "3. See total amount for all outings \n" +
                              "4. See amount for each outing by type");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    repo.DisplayAllOutings();
                    break;
                case "2":
                    Console.WriteLine("What kind of event are you adding? \n" +
                                      "1. Golf \n" +
                                      "2. Bowling \n" +
                                      "3. Amusement Park \n" +
                                      "4. Concert");
                    string eventChoice = Console.ReadLine();
                    switch (eventChoice)
                    {
                        case "1":
                            golfOuting++;
                            break;
                        case "2":
                            bowlOuting++;
                            break;
                        case "3":
                            amusementOuting++;
                            break;
                        case "4":
                            concertOuting++;
                            break;
                        default:
                            break;
                    }
                    break;
                case "3":

                    break;
                case "4":
                    break;
                default:
                    break;
            }

        }
    }
}
