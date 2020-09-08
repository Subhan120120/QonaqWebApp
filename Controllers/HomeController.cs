using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRepository<MenuItem> menuItemRepo;
        public readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public HomeController(IRepository<MenuItem> menuItemRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.menuItemRepo = menuItemRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }

        public IActionResult Index()
        {
            //IList<MenuItem> melumat = menuItemRepo.GetAll().Include(x => x.MenuItemGroup).ToList();
            return View();
        }

        public IActionResult About()
        {
            var hoqqa = menuItemGroupRepo.GetAll().FirstOrDefault();
            return View();
        }

        public IActionResult Menu()
        {
            IList<MenuItemGroup> menuItemGroup = menuItemGroupRepo.GetAll().Include(x => x.menuItems).ToList();
            return View(menuItemGroup);
        }

        public IActionResult Test()
        {
            IList<MenuItemGroup> menuItemGroupTest = menuItemGroupRepo.GetAll().Include(x => x.menuItems).ToList();
            return View(menuItemGroupTest);
        }

    }
}
