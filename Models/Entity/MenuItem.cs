using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QonaqWebApp.Models.Entity
{
    public class MenuItem: BaseEntity
    {
        public string MenuItemText { get; set; }
        public string MenuItemDescription { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int MenuItemGroupId { get; set; }
        public MenuItemGroup MenuItemGroup { get; set; }

    }
}
