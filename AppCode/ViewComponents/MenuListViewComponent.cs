using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Helpers;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QonaqWebApp.AppCode.Infrastructure;

namespace QonaqWebApp.AppCode.ViewComponents
{
    [ViewComponent]
    public class MenuList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Product product)
        {
            return View(product);
        }
    }
}
