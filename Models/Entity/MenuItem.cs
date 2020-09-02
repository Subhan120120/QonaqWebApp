using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string MenuItemText { get; set; }
        public string MenuItemDescription { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        
        public MenuItemGroup MenuItemGroup { get; set; }

    }
}
