using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class Reservation:BaseEntity
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(40, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string Name { get; set; }

        [DisplayName("Telefon Nömrəsi")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(40, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string PhoneNumber { get; set; }

        [DisplayName("Qonaq Sayı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public int NumberOfGuest { get; set; }

        [DisplayName("Başlama Vaxtı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public DateTime StartTime { get; set; }

        [DisplayName("Bitmə Vaxtı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public DateTime EndTime { get; set; }

        [DisplayName("Masa")]
        public int? DineInTableId { get; set; }

        [DisplayName("Bölmə")]
        public int DineInTableGroupId { get; set; }

        public virtual DineInTable DineInTable { get; set; }
        public virtual DineInTableGroup DineInTableGroup { get; set; }
    }
}
