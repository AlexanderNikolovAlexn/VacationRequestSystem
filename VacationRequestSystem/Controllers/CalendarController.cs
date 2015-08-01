using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationRequestSystem.Models;

namespace VacationRequestSystem.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult DisplayCalendar(int userId)
        {
            Random random = new Random();
            //DateTime currentMonth = new DateTime(DateTime.Now.Year, random.Next(1, 12), 1);
            DateTime currentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            CalendarModel calendar = new CalendarModel(currentMonth);

            return PartialView("_CalendarPartial", calendar);
        }
    }
}