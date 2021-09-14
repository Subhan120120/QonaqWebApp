using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        public readonly IRepository<Customer> customerRepo;
        public readonly IRepository<Order> orderRepo;

        public OrderController(IRepository<Customer> customerRepo,
                               IRepository<Order> orderRepo)
        {
            this.customerRepo = customerRepo;
            this.orderRepo = orderRepo;
        }


        public IActionResult Index()
        {
            List<Order> orders = orderRepo.GetAll(x => x.Sended == false).Include(x => x.Customer)
                                                   .Include(x => x.MenuItem).ToList();
            List<Customer> customers = customerRepo.GetAll(x => x.IsActive == true).ToList();
            OrderVM orderVM = new OrderVM(orders, customers);

            return View(orderVM);
        }

        public IActionResult Sended(int id)
        {
            foreach (var item in orderRepo.GetAll(x => x.CustomerId == id))
            {
                item.Sended = true;
            }
            customerRepo.GetAll(x => x.Id == id).FirstOrDefault().IsActive = false;
            orderRepo.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
