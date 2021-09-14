using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QonaqWebApp.Models.Entity
{
    public class MenuItem : BaseEntity
    {
        [DisplayName("Menyu Adı")]
        [MaxLength(40,ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public string MenuItemName { get; set; }

        [DisplayName("Menyunun Tərkibi")]
        [MaxLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string MenuItemDescription { get; set; }

        [DisplayName("Qiyməti")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [Range(0.01, 100.00, ErrorMessage = "{0} {1} - {2} aralığında olmalıdır.")]
        [DataType(DataType.Currency, ErrorMessage = "{1} üçün uyğun format daxil edilməlidir.")]
        //[DisplayFormat(DataFormatString = "{0:C0}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [DisplayName("Şəkli")]
        [MaxLength(150, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string ImagePath { get; set; }

        [DisplayName("Qurupu")]
        [Required(ErrorMessage = "Boş buraxıla bilməz.")]
        public int MenuItemGroupId { get; set; }

        public virtual MenuItemGroup MenuItemGroup { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}
