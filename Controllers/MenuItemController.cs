using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;

namespace QonaqWebApp.Controllers
{
    public class MenuItemController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;
        public readonly IRepository<MenuItem> menuItemRepo;

        public MenuItemController(IRepository<AppDetail> appDetailRepo,
                                IRepository<MenuItem> menuItemRepo)
        {
            this.appDetailRepo = appDetailRepo;
            this.menuItemRepo = menuItemRepo;
        }
        public IActionResult Index()
        {
            ViewBag.menuItems = menuItemRepo.GetAll();
            return View();
        }
    }
}
