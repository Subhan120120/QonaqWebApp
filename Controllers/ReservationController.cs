using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

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

            if (TempData.ContainsKey("Notify"))
                ViewBag.Notify = TempData["Notify"] as string;


            List<AppDetail> appDetailList = appDetailRepo.GetAll(x => x.Id == 1 || x.Id <= 17 && x.Id >= 15).ToList();
            ReservationVM reservationVM = new ReservationVM(appDetailList);
            return View(reservationVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reserve(ReservationVM reservationVM)
        {
            ViewBag.TblGrp = new SelectList(dineInTableGroupRepo.GetAll(), "Id", "TableGroupName");
            ViewBag.DnInTbl = new SelectList(dineInTableRepo.GetAll(), "Id", "TableName");

            reservationVM.Reservation.EndTime = reservationVM.Reservation.StartTime.AddHours(1);

            ModelState["Reservation.Id"].ValidationState = ModelValidationState.Valid;
            if (!ModelState.IsValid)
                return View(reservationVM.Reservation);

            reservationRepo.Add(reservationVM.Reservation);

            int rowAffected = reservationRepo.SaveChanges();
            if (rowAffected > 0)
                TempData["Notify"] = "Success";
            else
                TempData["Notify"] = "Error";

            return RedirectToAction("Reserve");
        }
    }
}
