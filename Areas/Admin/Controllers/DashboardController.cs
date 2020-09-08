using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        public readonly IRepository<MenuItem> menuItemRepo;
        public readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public DashboardController(IRepository<MenuItem> menuItemRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.menuItemRepo = menuItemRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }

        public IActionResult Index()
        {
            IList<MenuItem> melumat = menuItemRepo.GetAll().Include(x => x.MenuItemGroup).ToList();
            return View(melumat);
        }

        public IActionResult Testing()
        {
            ViewBag.Gr = menuItemGroupRepo.GetAll().ToList();
            IList<MenuItem> melumat = menuItemRepo.GetAll().Include(x => x.MenuItemGroup).ToList();
            return View(melumat);
        }

        [HttpGet]
        public JsonResult GetMenuGroup()
        {
            var list = new List<object>();

            List<MenuItemGroup> menuItemGroup = menuItemGroupRepo.GetAll().ToList();
            for (var i = 0; i < menuItemGroup.Count; i++)
            {
                var obj = new
                {
                    value = menuItemGroup[i].Id.ToString(),
                    text = menuItemGroup[i].MenuItemGroupText
                };

                list.Add(obj);
            }
            return Json(list);
        }

        [HttpPost]
        public JsonResult GetMenuGroup(MenuItem menuItem)
            {
            menuItemRepo.GetById(menuItem.Id).MenuItemGroupId = menuItem.MenuItemGroup.Id;
            menuItemRepo.SaveChanges();
            
            return Json(new
        {
            value = 0,
            text = "Example"
        });
        }
    }
}