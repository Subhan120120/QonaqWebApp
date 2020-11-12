using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.ViewModel
{
    public class ReservationVM
    {
        public ReservationVM()
        {
        }

        public ReservationVM(List<AppDetail> appDetails)
        {
            this.AppDetails = appDetails;
        }

        public ReservationVM(List<AppDetail> appDetails, Reservation reservation)
            : this(appDetails)
        {
            this.Reservation = reservation;
        }

        public List<AppDetail> AppDetails { get; set; }
        public Reservation Reservation { get; set; }
    }
}
