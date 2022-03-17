using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Models.ViewModel
{
    public class FilterVM
    {
        public FilterVM()
        {
        }

        public FilterVM(List<Order> orders)
        {
            this.Orders = orders;
        }

        public FilterVM(List<Order> orders, List<Customer> customers)
            : this(orders)
        {
            this.Customers = customers;
        }

        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
