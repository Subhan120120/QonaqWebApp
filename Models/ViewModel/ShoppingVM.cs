using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Models.ViewModel
{
    public class ShoppingVM
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<MenuItem> findAll()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem()
                {
                    Id = 1
                }
            };
            return MenuItems;
        }
        public MenuItem find(int id)
        {
            List<MenuItem> MenuItems = findAll();
            var prod = MenuItems.Where(a => a.Id == id).FirstOrDefault();
            return prod;


        }
    }
}
