using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Helpers;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Controllers
{
    public class ShoppingCartController : Controller
    {

        public readonly IRepository<AppDetail> appDetailRepo;
        public readonly IRepository<MenuItem> menuItemRepo;

        public ShoppingCartController(IRepository<AppDetail> appDetailRepo,
                                IRepository<MenuItem> menuItemRepo)
        {
            this.appDetailRepo = appDetailRepo;
            this.menuItemRepo = menuItemRepo;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.MenuItem.Price * item.Quantity);
            return View();
        }

        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart") == null)
            {
                List<ShoppingItem> cart = new List<ShoppingItem>();
                cart.Add(new ShoppingItem { MenuItem = menuItemRepo.GetById(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ShoppingItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ShoppingItem { MenuItem = menuItemRepo.GetById(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<ShoppingItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<ShoppingItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].MenuItem.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
