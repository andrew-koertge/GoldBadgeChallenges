using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge1Console;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewMenuItem_ReturnList()
        {
            //Arrange
            MenuRepository repo = new MenuRepository();
           
            string itemName = "Hamburger";
            int itemNumber = 5;
            string itemDescription = "A delicious hamburger with cheese, lettuce, tomato, and mayo on a bun.";
            decimal itemPrice = 11.00m;
            List<string> listOfIngredients = new List<string>();
            MenuItems menuItem = new MenuItems(itemNumber, itemName, itemDescription, listOfIngredients, itemPrice);

            //Act
            repo.AddNewItem(menuItem);

            //Assert
            Assert.AreEqual("Hamburger", menuItem.ItemName);
        }

        [TestMethod]
        public void DeleteMenuItem_ReturnsUpdatedListOfItems()
        {
            //Arrange
            MenuRepository repo = new MenuRepository();
            string itemName = "Club Sandwich";
            int itemNumber = 1;
            string itemDescription = "Turkey and ham piled high on sourdough bread with lettuce, tomato, bacon, and our special aoili.";
            decimal itemPrice = 10.00m;
            List<string> listOfIngredients = new List<string>();
            MenuItems menuItem = new MenuItems(itemNumber, itemName, itemDescription, listOfIngredients, itemPrice);

            //Act
            repo.DeleteMenuItem(itemName);

            //Assert
            Assert.AreEqual(itemName, menuItem.ItemName);
        }
    }
}
