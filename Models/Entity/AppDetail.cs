using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class AppDetail : BaseEntity
    {
        [DisplayName("Web Başlıq")]
        [StringLength(30, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string WebTitle { get; set; }

        [DisplayName("Ünvan")]
        [StringLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Address { get; set; }

        [Phone]
        [DisplayName("Əlaqə Telefonu")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [DisplayName("Email Adres")]
        public string EmailAddress { get; set; }

        [DisplayName("Facebook Ünvanı")]
        [StringLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Facebook { get; set; }

        [DisplayName("Twitter Ünvanı")]
        [StringLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Twitter { get; set; }

        [DisplayName("Instagram Ünvanı")]
        [StringLength(100, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Instagram { get; set; }

        [DisplayName("Müəssisə Haqqında Məlumat")]
        [StringLength(190, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string About { get; set; }

        [DisplayName("Başlıq")]
        [StringLength(30, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Heading { get; set; }

        [DisplayName("Alt Başlıq")]
        [StringLength(50, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string SubHeading { get; set; }

        [DisplayName("Açıqlama")]
        [StringLength(300, ErrorMessage = "{0} {1} simvoldan artıq ola bilməz ")]
        public string Description { get; set; }
        
    }
}
