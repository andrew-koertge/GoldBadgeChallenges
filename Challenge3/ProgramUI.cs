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
            Outing outing = new Outing();
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
                            repo.AddNewOuting();
                            break;
                        case "2":
                            bowlOuting++;
                            repo.AddNewOuting();
                            break;
                        case "3":
                            amusementOuting++;
                            repo.AddNewOuting();
                            break;
                        case "4":
                            concertOuting++;
                            repo.AddNewOuting();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Returning to main menu.");
                            Console.ReadLine();
                            Run();
                            break;
                    }
                    break;
                case "3":
                    repo.AddAllOutings();
                    break;
                case "4":
                    Console.WriteLine("Which outing do you want to see the total for? \n" +
                                      "1. Golf \n" +
                                      "2. Bowling \n" +
                                      "3. Amusement Park \n" +
                                      "4. Concert");
                    string totalChoice = Console.ReadLine();
                    switch (totalChoice)
                    {
                        case "1":
                            int golf = (int)Outing.TypeOfOuting.Golf;
                            repo.CalculateEachOuting(golf);
                            break;
                        case "2":
                            int bowling = (int)Outing.TypeOfOuting.Bowling;
                            repo.CalculateEachOuting(bowling);
                            break;
                        case "3":
                            int amusement = (int)Outing.TypeOfOuting.AmusementPark;
                            repo.CalculateEachOuting(amusement);
                            break;
                        case "4":
                            int concert = (int)Outing.TypeOfOuting.Concert;
                            repo.CalculateEachOuting(concert);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Returning to main menu.");
                    Console.ReadLine();
                    Run();
                    break;
            }

        }
    }
}
