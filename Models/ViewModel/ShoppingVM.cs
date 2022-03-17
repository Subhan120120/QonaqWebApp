using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Models.ViewModel
{
    public class ShoppingVM
    {
        public List<AppDetail> AppDetails { get; set; }
        public List<Order> Orders { get; set; }
        public Customer Customer { get; set; }

        public ShoppingVM()
        {
        }

        public ShoppingVM(List<AppDetail> appDetails)
        {
            this.AppDetails = appDetails;
        }

        public ShoppingVM(List<AppDetail> appDetails, List<Order> orders)
            : this(appDetails)
        {
            this.Orders = orders;
        }

        public ShoppingVM(List<AppDetail> appDetails, List<Order> orders, Customer customer)
            : this(appDetails, orders)
        {
            this.Customer = customer;
        }
    }
}
