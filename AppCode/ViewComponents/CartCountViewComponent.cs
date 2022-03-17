﻿using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Helpers;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.ViewComponents
{
    [ViewComponent]
    public class CartCount : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Order> cart = SessionHelper.GetObjectFromJson<List<Order>>(HttpContext.Session, "cart");

            int cartCount = 0;
            if (cart != null)
            {
                cartCount = cart.Sum(item => item.Quantity);
            }
            return View(cartCount);
        }
    }
}
