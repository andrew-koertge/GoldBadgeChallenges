using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Console
{
    class ProgramUI
    {
        MenuRepository repo = new MenuRepository();
        MenuItems menuItems = new MenuItems();
        public void Run()
        {

            Console.WriteLine("Welcome to Komodo Cafe! Please make your selection: \n" +
                                "1. Place an order. \n" +
                                "2. Create new menu item. \n" +
                                "3. Delete menu item. \n" +
                                "4. List all items. ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("What would you like to eat today? Please select a number from the following: \n" +
                                       "1. Club sandwich \n" +
                                       "2. House salad \n" +
                                       "3. Tomato soup \n" +
                                       "4. Chocolate cake \n");
                    string foodChoice = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("What will the new item be called?");
                    string newMenuItem = Console.ReadLine();
                    menuItems.ItemName = newMenuItem;
                    repo.AddNewItem(menuItems);
                    break;
                case "3":
                    Console.WriteLine("Which item do you want to remove?");
                    string deletedMenuItem = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Here are all current menu items: \n");
                    repo.SeeMenuItems();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
