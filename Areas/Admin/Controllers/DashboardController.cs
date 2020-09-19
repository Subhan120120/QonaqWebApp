using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text.Json;



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

        [HttpGet]
        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.MenuItemGroup = new SelectList(menuItemGroupRepo.GetAll(), "Id", "MenuItemGroupText");
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
        [ValidateAntiForgeryToken]
        public JsonResult AddOrEdit(int id, MenuItem menuItem)
        {
            ViewBag.MenuItemGroup = new SelectList(menuItemGroupRepo.GetAll(), "Id", "MenuItemGroupText");

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


                MenuItem AddedRow = menuItemRepo.GetAll(x => x.Id == menuItem.Id).Include(x => x.MenuItemGroup).FirstOrDefault();

                //string jsonResult = JsonConvert.SerializeObject(melumat, Formatting.Indented, options);


                var JSONoptions = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
                return Json(new { isValid = true, menuItem = AddedRow }, JSONoptions);
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", menuItem) });
        }

        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int[] selectRowsArr)
        {
            foreach (int item in selectRowsArr)
            {
                menuItemRepo.Delete(menuItemRepo.GetById(item));
            }
                menuItemRepo.SaveChanges();

            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", menuItemRepo.GetAll().ToList()) });
        }

    }
}