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

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
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
