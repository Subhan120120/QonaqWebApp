using Microsoft.AspNetCore.Mvc;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteLayoutController : Controller
    {
        public readonly IRepository<AppDetail> appDetailRepo;

        public SiteLayoutController(IRepository<AppDetail> appDetailRepo)
        {
            this.appDetailRepo = appDetailRepo;
        }

        [HttpGet]
        public IActionResult PageLayout()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id == 1).ToList();
            return View(appDetailList);
        }

        [HttpGet]
        public IActionResult PageIndex()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id != 1 && x.Id <= 5).ToList();
            return View(appDetailList);
        }

        [HttpGet]
        public IActionResult PageMenu()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id == 10).ToList();
            return View("PageIndex", appDetailList);
        }

        [HttpGet]
        public IActionResult PageReserve()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id >= 15 && x.Id <= 17).ToList();
            return View("PageIndex", appDetailList);
        }

        [HttpGet]
        public IActionResult PageAbout()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id >= 20 && x.Id <= 22).ToList();
            return View("PageIndex", appDetailList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SavePage(List<AppDetail> appDetailList)
        {
            appDetailRepo.UpdateRange(appDetailList);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageLayout");
        }
    }
}
