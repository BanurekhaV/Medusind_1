using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4HtmlHelpersPrj.Models;

namespace Day4HtmlHelpersPrj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View(emp);
        }
    }
}