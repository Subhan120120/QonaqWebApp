using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.ViewModel
{
    public class ScheduleVM
    {
        public ScheduleVM()
        {
        }

        public ScheduleVM(List<Reservation> reservations)
        {
            this.Reservations = reservations;
        }

        public ScheduleVM(List<Reservation> reservations, List<DineInTable> dineInTables)
            : this(reservations)
        {
            this.DineInTables = dineInTables;
        }

        public ScheduleVM(List<Reservation> reservations, List<DineInTable> dineInTables, List<DineInTableGroup> dineInTableGroups)
            : this(reservations, dineInTables)
        {
            this.DineInTableGroups = dineInTableGroups;
        }

        public List<Reservation> Reservations { get; set; }
        public List<DineInTable> DineInTables { get; set; }
        public List<DineInTableGroup> DineInTableGroups { get; set; }
    }
}