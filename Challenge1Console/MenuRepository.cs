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
        public bool DeleteMenuItem(string name)
        {
            MenuItems item = GetMenuItemsByName(name);

            if(item == null)
            {
                return false;
            }

            int menuCount = _listofMenuItems.Count;
            _listofMenuItems.Remove(item);

            if(menuCount > _listofMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper method
        public MenuItems GetMenuItemsByName(string name)
        {
            foreach(MenuItems item in _listofMenuItems)
            {
                if(item.ItemName == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
