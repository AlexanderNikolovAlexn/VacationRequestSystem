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
            CalendarModel calendar = new CalendarModel();

            return PartialView("_CalendarPartial", calendar);
        }
    }
}