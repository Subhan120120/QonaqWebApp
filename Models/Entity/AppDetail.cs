using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Entity
{
    public class AppDetail: BaseEntity
    {
        public string WebTitle { get; set; }
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string About { get; set; }
        public string CarouselTitle1 { get; set; }
        public string CarouselSubTitle1 { get; set; }
        public string CarouselTitle2 { get; set; }
        public string CarouselSubTitle2 { get; set; }
        public string CarouselTitle3 { get; set; }
        public string CarouselSubTitle3 { get; set; }
        public string CarouselTitle4 { get; set; }
        public string CarouselSubTitle4 { get; set; }
    }
}
