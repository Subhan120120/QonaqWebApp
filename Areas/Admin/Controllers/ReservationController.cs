using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Entity;
using QonaqWebApp.Models.ViewModel;

namespace QonaqWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        public readonly IRepository<Reservation> reservationRepo;
        public readonly IRepository<DineInTable> dineInTableRepo;
        public readonly IRepository<DineInTableGroup> dineInTableGroupRepo;

        public ReservationController(IRepository<Reservation> reservationRepo,
                                    IRepository<DineInTableGroup> dineInTableGroupRepo,
                                    IRepository<DineInTable> dineInTableRepo)
        {
            this.reservationRepo = reservationRepo;
            this.dineInTableRepo = dineInTableRepo;
            this.dineInTableGroupRepo = dineInTableGroupRepo;
        }
        public IActionResult Schedule()
        {
            var reservationVm = new ReservationVM(reservationRepo.GetAll().ToList(), dineInTableRepo.GetAll().ToList());
            return View(reservationVm);
        }
    }
}
