using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models;
using QonaqWebApp.Models.Entity;

namespace QonaqWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<MenuItem> menuItemRepo;
        readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public HomeController(IRepository<MenuItem> menuItemRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.menuItemRepo = menuItemRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
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
