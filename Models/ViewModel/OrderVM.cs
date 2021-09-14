using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Models.ViewModel
{
    public class OrderVM
    {
        public OrderVM()
        {
        }

        public OrderVM(List<Order> orders)
        {
            this.Orders = orders;
        }

        public OrderVM(List<Order> orders, List<Customer> customers)
            : this(orders)
        {
            this.Customers = customers;
        }

        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
