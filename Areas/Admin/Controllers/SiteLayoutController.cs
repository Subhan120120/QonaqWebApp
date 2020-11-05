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

        public IActionResult PageLayout()
        {
            var appDetail = appDetailRepo.GetById(1);
            return View(appDetail);
        }

        [HttpPost]
        public IActionResult PageLayout(AppDetail appDetail)
        {
            appDetailRepo.Update(appDetail);
            appDetailRepo.SaveChanges();
            return RedirectToAction("PageLayout");
        }

        [HttpGet]
        public IActionResult PageOther()
        {
            List<AppDetail> appDetailList = appDetailRepo.GetAll().ToList();
            return View(appDetailList);
        }        
        
        [HttpPost]
        public IActionResult PageOther(List<AppDetail> appDetailList)
        {
            //appDetailRepo.Update(appDetailList);
            //appDetailRepo.SaveChanges();
            return RedirectToAction("PageOther");
        }
    }
}
