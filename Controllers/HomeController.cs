using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Helpers;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;

        public HomeController(IRepository<AppDetail> appDetailRepo)
        {
            this.appDetailRepo = appDetailRepo;
        }

        //[OutputCache(Duration = 5 * 60)]
        //public ActionResult ShoppingCart(string section)
        //{
        //    List<ShoppingItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart");
        //    int cartCount = cart.Count;
        //    return PartialView("_cartCount", cartCount);
        //}

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

    }
}
