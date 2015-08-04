using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacationRequestSystem.Models;

namespace VacationRequestSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var listVacationTypes = VacationType.InitVacationTypes();
            return View("Index", listVacationTypes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}