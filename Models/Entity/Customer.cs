using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class Customer : BaseEntity
    {
        [DisplayName("Ad")]
        [StringLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        [Required(ErrorMessage = "{0} daxil edilməlidir")]
        public string Name { get; set; }

        [DisplayName("Ünvan")]
        [StringLength(200, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        [Required(ErrorMessage = "{0} daxil edilməlidir")]
        public string Address { get; set; }

        [Phone]
        [DisplayName("Əlaqə Telefonu")]
        [StringLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        [Required(ErrorMessage = "{0} daxil edilməlidir")]
        public string PhoneNumber { get; set; }        

        [DisplayName("Açıqlama")]
        [StringLength(300, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Description { get; set; }
        public bool IsActive { get; set; }


        public virtual List<Order> Orders { get; set; }

    }
}
