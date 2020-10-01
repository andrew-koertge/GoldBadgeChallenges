using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class OutingRepository
    {
        Outing outing = new Outing();
        ProgramUI program = new ProgramUI();
        private List<string> OutingList = new List<string>();

        //Option 1: List all outing types
        public void DisplayAllOutings()
        {
            Console.WriteLine("Here's a list of all outings: \n");
            foreach (string i in Enum.GetValues(typeof(Outing.TypeOfOuting)))
            {
                Console.WriteLine(i + "\n");
            }
        }

        //Option 2: Add new outing
        public void AddNewOuting(string outing)
        {
            OutingList.Add(outing);
        }

        //Option 3: Calculate all outings
        public void AddAllOutings(int numberOfOutings)
        {
            decimal outingCost = numberOfOutings * 500.00m;
            Console.WriteLine("Total cost of all outings: " + outingCost);
        }

        //Option 4: Calculate Each Type of Outing Separately
        public void CalculateEachOuting(Outing.TypeOfOuting typeOfOuting, int numberOfPeople)
        {
            
            if (typeOfOuting.Equals(1)) {
                outing.CostPerEvent = 500.00m;
            } else if (typeOfOuting.Equals(2))
            {
                outing.CostPerEvent = 200.00m;
            } else if (typeOfOuting.Equals(3))
            {
                outing.CostPerEvent = 750.00m;
            } else if (typeOfOuting.Equals(4))
            {
                outing.CostPerEvent = 1000.00m;
            }
            outing.CostPerPerson = outing.CostPerEvent / numberOfPeople;
            Console.WriteLine($"Total cost of {typeOfOuting} is: {outing.CostPerPerson}");
        }
    }
}
