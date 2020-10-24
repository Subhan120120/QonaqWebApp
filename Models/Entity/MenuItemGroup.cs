using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class MenuItemGroup : BaseEntity
    {

        [DisplayName("Qurup Adı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(40, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string MenuItemGroupName { get; set; }
        public virtual List<MenuItem> menuItems { get; set; }
    }
}
