using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace VacationRequestSystem.Models
{
    public class CalendarModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int[] Holidays { get; set; }
        public int[] WorkingWeekends { get; set; }
        public int[] PendingRequests { get; set; }
        public int[] ApprovedRequests { get; set; }
    }
}