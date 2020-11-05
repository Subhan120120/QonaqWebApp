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

        public ReservationVM(AppDetail appDetail)
        {
            this.AppDetail = appDetail;
        }

        public ReservationVM(AppDetail appDetail, Reservation reservation)
            : this(appDetail)
        {
            this.Reservation = reservation;
        }

        public AppDetail AppDetail { get; set; }
        public Reservation Reservation { get; set; }
    }
}
