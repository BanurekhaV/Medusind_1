using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2MVCPrj.Models;

namespace Day2MVCPrj.Controllers
{
    public class MultiTableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultiTable
        public ActionResult Index()
        {
            return View();
        }

        //using navigation properties to connect multiple table fata
        public ActionResult MultiData()
        {
            return View(db.Orders.ToList());
        }
    }
}