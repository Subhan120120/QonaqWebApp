using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QonaqWebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult DiscountCard()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }
    }
}
