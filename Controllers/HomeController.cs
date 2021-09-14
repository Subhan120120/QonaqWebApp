using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }
    }
}
