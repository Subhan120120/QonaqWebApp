using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;

namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        public readonly IRepository<MenuItem> menuItemRepo;
        public readonly IRepository<MenuItemGroup> menuItemGroupRepo;

        public MenuController(IRepository<MenuItem> menuItemRepo,
                                IRepository<MenuItemGroup> menuItemGroupRepo)
        {
            this.menuItemRepo = menuItemRepo;
            this.menuItemGroupRepo = menuItemGroupRepo;
        }


        public IActionResult Menu()
        {
            IList<MenuItem> melumat = menuItemRepo.GetAll().Include(x => x.MenuItemGroup).ToList();
            return View(melumat);
        }

        [HttpGet]
        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.MenuItemGroup = new SelectList(menuItemGroupRepo.GetAll(), "Id", "MenuItemGroupName");
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
        public JsonResult AddOrEdit(int id, MenuItem menuItem, IFormFile ImagePath)
        {
            ViewBag.MenuItemGroup = new SelectList(menuItemGroupRepo.GetAll(), "Id", "MenuItemGroupName");

            if (ModelState.IsValid)
            {

                if (ImagePath != null)
                {
                    string randomFileName = Path.Combine("wwwroot", "Uploads", "Images", $"{Guid.NewGuid().ToString()}{Path.GetExtension(ImagePath.FileName)}");
                    using (var stream = new FileStream(randomFileName, FileMode.Create))
                        ImagePath.CopyTo(stream);
                    menuItem.ImagePath = Path.GetFileName(randomFileName);
                }


                if (id == 0)
                {
                    menuItemRepo.Add(menuItem);
                    menuItemRepo.SaveChanges();
                }
                else
                {
                    try
                    {
                        if (ImagePath != null)
                            menuItemRepo.GetById(id).ImagePath = menuItem.ImagePath;
                        menuItemRepo.GetById(id).MenuItemDescription = menuItem.MenuItemDescription;
                        menuItemRepo.GetById(id).MenuItemGroupId = menuItem.MenuItemGroupId;
                        menuItemRepo.GetById(id).MenuItemName = menuItem.MenuItemName;
                        menuItemRepo.GetById(id).Price = menuItem.Price;
                        menuItemRepo.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                    }
                }

                MenuItem AddedRow = menuItemRepo.GetAll(x => x.Id == menuItem.Id).Include(x => x.MenuItemGroup).FirstOrDefault();

                //string jsonResult = JsonConvert.SerializeObject(melumat, Formatting.Indented, options);


                return Json(new { isValid = true, menuItem = AddedRow }, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            }
            return Json(new { isValid = false });
        }

        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int[] selectRowsArr)
        {
            foreach (int item in selectRowsArr)
            {
                MenuItem MenuRow = menuItemRepo.GetById(item);
                menuItemRepo.Delete(MenuRow);
                var pathImage = Path.Combine("wwwroot", "Uploads", "Images", MenuRow.ImagePath);
                if (System.IO.File.Exists(pathImage))
                    System.IO.File.Delete(pathImage);
            }
            int affectedRow = menuItemRepo.SaveChanges();

            if (affectedRow != 0)
                return Json(new { isValid = true });
            else
                return Json(new { isValid = false });
        }

    }
}
