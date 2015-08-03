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
        public List<VacationType> VacationType { get; set; }        

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
            this.VacationType = InitVacationTypes();
        }

        private List<VacationType> InitVacationTypes()
        {
            List<VacationType> listVacationType = new List<VacationType>();
            listVacationType.Add(new VacationType(1, "Vacation", true));
            listVacationType.Add(new VacationType(2, "Unpaid vacation", false));
            listVacationType.Add(new VacationType(3, "Sick leave", false));
            listVacationType.Add(new VacationType(4, "Personal", false));
            listVacationType.Add(new VacationType(5, "Pregnancy", false));

            return listVacationType;
        }
    }

    public class VacationType
    {
        public int VacationTypeId { get; set; }
        public string VacationTypeName { get; set; }
        public bool IsSelected { get; set; }

        public VacationType(int VacationTypeId, string VacationTypeName, bool IsSelected)
        {
            this.VacationTypeId = VacationTypeId;
            this.VacationTypeName = VacationTypeName;
            this.IsSelected = IsSelected;
        }
    }
}