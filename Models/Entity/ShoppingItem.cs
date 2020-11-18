using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class ShoppingItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
