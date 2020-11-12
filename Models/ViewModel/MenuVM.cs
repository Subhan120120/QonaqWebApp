using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.ViewModel
{
    public class MenuVM
    {
        public MenuVM()
        {
        }

        public MenuVM(List<AppDetail> appDetails)
        {
            this.AppDetails = appDetails;
        }

        public MenuVM(List<AppDetail> appDetails, List<MenuItemGroup> menuItemGroups)
            : this(appDetails)
        {
            this.MenuItemGroups = menuItemGroups;
        }

        public List<AppDetail> AppDetails { get; set; }
        public List<MenuItemGroup> MenuItemGroups { get; set; }
    }
}