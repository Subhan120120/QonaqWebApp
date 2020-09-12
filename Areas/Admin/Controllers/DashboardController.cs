using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QonaqWebApp.AppCode.Functions;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;
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

        public IActionResult AddOrEdit(int id = 0)
        {

            if (id == 0)
            {
                return View(new MenuItem());
            }
            else
            {
                var menuItem = menuItemRepo.GetById(id);
                if (menuItem == null)
                {
                    return NotFound();
                }
                return View(menuItem);
            }
        }


        [HttpPost]
        public IActionResult AddOrEdit(int id, MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    menuItemRepo.Add(menuItem);
                    menuItemRepo.SaveChanges();
                }
                else
                {
                    try
                    {
                        menuItemRepo.Update(menuItem);
                        menuItemRepo.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                    }

                }
                return Json(new { isValid = true, html = CustomFunctions.RenderRazorViewToString(this, "Index", menuItemRepo.GetAll().ToList())});
            }

            return Json(new { isValid = false, html = CustomFunctions.RenderRazorViewToString(this, "AddOrEdit", menuItem) });
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


        public JsonResult GetMenuGroup(MenuItem menuItem)
        {
            //if (menuItem.MenuItemGroup.Id != null)
            //{
            //    menuItemRepo.GetById(menuItem.Id).MenuItemGroupId = menuItem.MenuItemGroup.Id;
            //}

            menuItemRepo.Update(menuItem);

            menuItemRepo.SaveChanges();

            return Json(new
            {
                value = 0,
                text = "Ugurla Silindi"
            });
        }
    }
}