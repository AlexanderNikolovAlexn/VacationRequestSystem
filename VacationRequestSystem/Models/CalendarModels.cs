using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace VacationRequestSystem.Models
{
    public class CalendarModel
    {
        public DateTime CurrentMonth { get; set; }
        public List<DateTime> Holidays { get; set; }
        public List<DateTime> WorkingWeekends { get; set; }
        public List<DateTime> PendingRequests { get; set; }
        public List<DateTime> ApprovedRequests { get; set; }

        public CalendarModel(DateTime currentMonth, List<DateTime> holidays, List<DateTime> workingWeekends, List<DateTime> pendingRequests, List<DateTime> approvedRequests)
        {
            this.CurrentMonth = currentMonth;
            this.Holidays = holidays;
            this.WorkingWeekends = workingWeekends;
            this.PendingRequests = pendingRequests;
            this.ApprovedRequests = approvedRequests;
        }

        public CalendarModel(DateTime currentMonth)
        {
            this.CurrentMonth = currentMonth;
            this.Holidays = null;
            this.WorkingWeekends = null;
            this.PendingRequests = null;
            this.ApprovedRequests = null;
        }
    }
}