using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;
        public readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public HomeController(IRepository<AppDetail> appDetailRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.appDetailRepo = appDetailRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }

        public IActionResult Index()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id != 1 && x.Id <= 5).ToList();
            return View(appDetailList);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Menu()
        {
            IList<MenuItemGroup> menuItemGroup = menuItemGroupRepo.GetAll().Include(x => x.menuItems).Where(x => x.menuItems.Any()).ToList();
            return View(menuItemGroup);
        }

    }
}
