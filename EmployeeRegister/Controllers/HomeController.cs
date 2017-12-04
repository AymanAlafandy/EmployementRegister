using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeRegister.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Employee Managemnt register for detail and smooth employee details management.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Computer()
        {
            return View();
        }

        public ActionResult NetSalary()
        {
            return View();
        }
        public ActionResult SalaryNetCalculations()
        {
            return View();
        }
    }
}