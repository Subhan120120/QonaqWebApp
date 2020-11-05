using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;

namespace QonaqWebApp.Controllers
{
    public class ReservationController : Controller
    {
        public readonly IRepository<Reservation> reservationRepo;
        public readonly IRepository<DineInTableGroup> dineInTableGroupRepo;
        public readonly IRepository<DineInTable> dineInTableRepo;
        public readonly IRepository<AppDetail> appDetailRepo;

        public ReservationController(IRepository<Reservation> reservationRepo,
                                    IRepository<DineInTableGroup> dineInTableGroupRepo,
                                    IRepository<DineInTable> dineInTableRepo,
                                    IRepository<AppDetail> appDetailRepo)
        {
            this.reservationRepo = reservationRepo;
            this.dineInTableGroupRepo = dineInTableGroupRepo;
            this.dineInTableRepo = dineInTableRepo;
            this.appDetailRepo = appDetailRepo;
        }

        [HttpGet]
        public IActionResult Reserve()
        {
            ViewBag.TblGrp = new SelectList(dineInTableGroupRepo.GetAll(), "Id", "TableGroupName");
            ViewBag.DnInTbl = new SelectList(dineInTableRepo.GetAll(), "Id", "TableName");

            ReservationVM reservationVM = new ReservationVM(appDetailRepo.GetById(1));
            return View(reservationVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reserve(Reservation reservation)
        {
            ViewBag.TblGrp = new SelectList(dineInTableGroupRepo.GetAll(), "Id", "TableGroupName");
            ViewBag.DnInTbl = new SelectList(dineInTableRepo.GetAll(), "Id", "TableName");

            reservation.EndTime = reservation.StartTime.AddHours(1);

            ModelState["Id"].ValidationState = ModelValidationState.Valid;
            if (!ModelState.IsValid)
                return View(reservation);

            reservationRepo.Add(reservation);
            reservationRepo.SaveChanges();
            return RedirectToAction("Reserve");
        }

        public IActionResult Test()
        {
            List<AppDetail> appdetailList = appDetailRepo.GetAll().ToList();
            return View(appdetailList);
        }

        [HttpPost]
        public IActionResult Test(List<AppDetail> appdetailList)
        {
            return View(appdetailList);
        }
    }
}
