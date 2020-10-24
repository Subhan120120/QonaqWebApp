using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;

namespace QonaqWebApp.Controllers
{
    public class ReservationController : Controller
    {
        public readonly IRepository<Reservation> reservationRepo;
        public readonly IRepository<DineInTableGroup> dineInTableGroupRepo;
        public readonly IRepository<DineInTable> dineInTableRepo;

        public ReservationController(IRepository<Reservation> reservationRepo,
                                    IRepository<DineInTableGroup> dineInTableGroupRepo,
                                    IRepository<DineInTable> dineInTableRepo)
        {
            this.reservationRepo = reservationRepo;
            this.dineInTableGroupRepo = dineInTableGroupRepo;
            this.dineInTableRepo = dineInTableRepo;
        }

        [HttpGet]
        public IActionResult Reserve()
        {
            ViewBag.TblGrp = new SelectList(dineInTableGroupRepo.GetAll(), "Id", "TableGroupName");
            ViewBag.DnInTbl = new SelectList(dineInTableRepo.GetAll(), "Id", "TableName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reserve(Reservation reservation)
        {
            ViewBag.TblGrp = new SelectList(dineInTableGroupRepo.GetAll(), "Id", "TableGroupName");
            ViewBag.DnInTbl = new SelectList(dineInTableRepo.GetAll(), "Id", "TableName");
            ModelState["Id"].ValidationState = ModelValidationState.Valid;
            if (!ModelState.IsValid)
            {
                return View(reservation);
            }
            reservationRepo.Add(reservation);
            reservationRepo.SaveChanges();
            return RedirectToAction("Reserve");
        }

        public IActionResult Test()
        {
            return View();
        }

    }
}
