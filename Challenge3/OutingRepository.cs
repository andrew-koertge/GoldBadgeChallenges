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
        private List<Outing> _outingList = new List<Outing>();

        //Option 1: List all outing types
        public void DisplayAllOutings()
        {
            Console.WriteLine("Here's a list of all outings: \n");
            foreach (Outing.TypeOfOuting i in Enum.GetValues(typeof(Outing.TypeOfOuting)))
            {
                Console.WriteLine(i + "\n");
            }
            Console.ReadLine();
            program.Run();
        }

        //Option 2: Add new outing
        public void AddNewOuting()
        {
            int outingTotal = 0;
            Console.WriteLine("New outing added.");
            outingTotal++;
            program.Run();
        }

        //Option 3: Calculate all outings
        public void AddAllOutings()
        {
            decimal totalCost = outing.CostPerEvent * 1000.00m;
            Console.WriteLine($"Total cost of all outings is: {totalCost}");
            Console.ReadLine();
            program.Run();
        }

        //Option 4: Calculate Each Type of Outing Separately
        public void CalculateEachOuting(int outingSelected)
        {
            
            if (outingSelected == 1) {
                outing.CostPerEvent = 500.00m;
                Console.WriteLine($"Total cost of golf outings is: {outing.CostPerEvent}");
                Console.ReadLine();
                program.Run();
            } 
            else if (outingSelected == 2)
            {
                outing.CostPerEvent = 200.00m;
                Console.WriteLine($"Total cost of bowling outings is: {outing.CostPerEvent}");
                Console.ReadLine();
                program.Run();
            } 
            else if (outingSelected == 3)
            {
                outing.CostPerEvent = 750.00m;
                Console.WriteLine($"Total cost of amusement park outings is: {outing.CostPerEvent}");
                Console.ReadLine();
                program.Run();
            } 
            else if (outingSelected == 4)
            {
                outing.CostPerEvent = 1000.00m;
                Console.WriteLine($"Total cost of concert outings is: {outing.CostPerEvent}");
                Console.ReadLine();
                program.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Returning to main menu.");
                Console.ReadLine();
                program.Run();
            }
        }
    }
}
