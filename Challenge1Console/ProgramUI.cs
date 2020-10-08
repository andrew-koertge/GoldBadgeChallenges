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
                    //Add new item name
                    Console.WriteLine("What will the new item be called?");
                    string newMenuItem = Console.ReadLine();
                    menuItems.ItemName = newMenuItem;
                    //Add new item description
                    Console.WriteLine("Give a brief description of the item.");
                    string newMenuDescription = Console.ReadLine();
                    menuItems.ItemDescription = newMenuDescription;
                    //Add new list of ingredients for item
                    bool addNewIngredient = true;
                    while (addNewIngredient)
                    {
                        Console.WriteLine("List an ingredient in the item.");
                        string newIngredient = Console.ReadLine();
                        menuItems.ListOfIngredients.Add(newIngredient);
                        Console.WriteLine("Do you have another ingredient to add? y/n");
                        string continueToAdd = Console.ReadLine();
                        if (continueToAdd == "y")
                        {
                            continue;
                        } 
                        else if (continueToAdd == "n")
                        {
                            addNewIngredient = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please type y or n to continue.");
                        }
                    }
                    //Add new item price
                    Console.WriteLine("What will the price of the item be?");
                    string newItemPrice = Console.ReadLine();
                    menuItems.ItemPrice = Decimal.Parse(newItemPrice);
                    //Add new item with all properties to menu list
                    repo.AddNewItem(menuItems);
                    break;
                case "3":
                    Console.WriteLine("Which item do you want to remove? \n" +
                                      "1. Club sandwich \n" +
                                      "2. House salad \n" +
                                      "3. Tomato soup \n" +
                                      "4. Chocolate cake \n");
                    string deletedMenuItem = Console.ReadLine();
                    switch (deletedMenuItem)
                    {
                        case "1":
                            repo.DeleteMenuItem(menuItems.ItemName);
                            break;
                        case "2":
                            repo.DeleteMenuItem(menuItems.ItemName);
                            break;
                        case "3":
                            repo.DeleteMenuItem(menuItems.ItemName);
                            break;
                        case "4":
                            repo.DeleteMenuItem(menuItems.ItemName);
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            Console.ReadLine();
                            Run();
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Here are all current menu items: \n");
                    repo.SeeMenuItems();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    Console.ReadLine();
                    Run();
                    break;
            }
        }
    }
}
