using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class DineInTableGroup:BaseEntity
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        [MaxLength(40, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz.")]
        public string TableGroupName { get; set; }

        [DisplayName("Qonaq Sayı")]
        [Required(ErrorMessage = "Boş buraxıla bilməz. ")]
        public int MaxGuest { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<DineInTable> DineInTables { get; set; }
    }
}
