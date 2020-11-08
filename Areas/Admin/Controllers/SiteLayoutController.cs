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
            var appDetail = appDetailRepo.GetById(1);
            return View(appDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PageLayout(AppDetail appDetail)
        {
            appDetailRepo.Update(appDetail);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageLayout");
        }

        [HttpGet]
        public IActionResult PageIndex()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id != 1 && x.Id <= 5).ToList();
            return View(appDetailList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PageIndex(List<AppDetail> appDetailList)
        {
            appDetailRepo.UpdateRange(appDetailList);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageIndex");
        }

        [HttpGet]
        public IActionResult PageMenu()
        {
            AppDetail appDetail = appDetailRepo.GetById(10);
            return View(appDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PageMenu(AppDetail appDetail)
        {
            appDetailRepo.Update(appDetail);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageMenu");
        }

        [HttpGet]
        public IActionResult PageReserve()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id >= 15 && x.Id <= 17).ToList();
            return View(appDetailList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PageReserve(List<AppDetail> appDetailList)
        {
            appDetailRepo.UpdateRange(appDetailList);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageReserve");
        }

        [HttpGet]
        public IActionResult PageAbout()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id >= 20 && x.Id <= 22).ToList();
            return View(appDetailList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PageAbout(List<AppDetail> appDetailList)
        {
            appDetailRepo.UpdateRange(appDetailList);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageReserve");
        }

    }
}
