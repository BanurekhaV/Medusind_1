using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterExceptionPrj.Models;

namespace FilterExceptionPrj.Controllers
{
    public class Action_FiltersController : Controller
    {
        // GET: Action_Filters
        public ActionResult Index()
        {
            return View();
        }

        [LogicFilter]
        public ActionResult ShowFilters()
        {
            return View();
        }
    }
}