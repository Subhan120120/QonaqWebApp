using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class MenuItemGroup
    {
        public int Id { get; set; }
        public string MenuItemGroupText { get; set; }
        public List<MenuItem> menuItems { get; set; }
    }
}
