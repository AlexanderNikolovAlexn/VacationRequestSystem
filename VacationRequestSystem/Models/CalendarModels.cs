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

        public CalendarModel()
        {
            this.CurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.Holidays = null;
            this.WorkingWeekends = null;
            this.PendingRequests = null;
            this.ApprovedRequests = null;
        }
    }
}