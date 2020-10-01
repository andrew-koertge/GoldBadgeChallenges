using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1Console
{
    public class MenuRepository
    {
        private List<MenuItems> _listofMenuItems = new List<MenuItems>(); 

        //create
        public void AddNewItem(MenuItems newItem)
        {
            _listofMenuItems.Add(newItem);
        }

        //read
        public List<MenuItems> SeeMenuItems()
        {
            return _listofMenuItems;
        }

        //delete
        public void DeleteMenuItem(MenuItems deletedItem)
        {
            _listofMenuItems.Remove(deletedItem);
        }
    }
}
