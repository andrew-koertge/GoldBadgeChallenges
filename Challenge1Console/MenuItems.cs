using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Console
{
    public class MenuItems
    {
        //properties
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public List<string> ListOfIngredients { get; set; }
        public decimal ItemPrice { get; set; }

        //empty constructor
        public MenuItems() { }

        //overloaded constructor
        public MenuItems(int itemNumber, string itemName, string itemDescription, List<string> listOfIngredients, decimal itemPrice)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            ItemDescription = itemDescription;
            ListOfIngredients = listOfIngredients;
            ItemPrice = itemPrice;
        }
    }
}
