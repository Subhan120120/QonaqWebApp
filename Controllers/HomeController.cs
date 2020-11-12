using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;
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
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id >= 20 && x.Id <= 22).ToList();
            return View(appDetailList);
        }

        public IActionResult Menu()
        {
            MenuVM menuVM = new MenuVM(appDetailRepo.GetAll(x => x.Id == 10).ToList(), menuItemGroupRepo.GetAll().Include(x => x.menuItems).Where(x => x.menuItems.Any()).ToList());
            return View(menuVM);
        }

    }
}
