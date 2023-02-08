using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index()
        {
            //int a = 10;
            //dynamic b;
            //b=10
            TempData.Keep();
            return View();
           // return RedirectToAction("CheckingTempdata");
        }

        public ActionResult CheckingTempdata()
        {
            return RedirectToAction("ViewMethod","Demo");
        }
        //viewbag and viewdata
        public ActionResult Rules()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry Your ID Card", "Be On Time"
            };
            //1. thru viewbag
            ViewBag.getrules = rules;

            //2. thru viewdata
            ViewData["followrules"] = rules;

            return View();
        }

        //to test if data inside viewbag/viewdata are transferable to other views
        public ActionResult Test_DataTransfer()
        {
            ViewBag.data1 = "Data 1";
            ViewData["data2"] = "Data 2";
            // return View();  //we should get data1 and data 2 in this view
            return Redirect("Index"); // we will not get the data transferred
        }

        //to maintain the state, we will use tempdata

        public ActionResult FirstRequest()
        {
            List<string> strlist = new List<string>();
            strlist.Add("Roses");
            strlist.Add("Jasmines");
            strlist.Add("Lilies");
            strlist.Add("Mogras");
            strlist.Add("Chrysanthimum");
            TempData["flowers"] = strlist;
            TempData.Keep();
             return View();
           // return RedirectToAction("SecondRequest");
        }

        public ActionResult SecondRequest()
        {
            //if(TempData["flowers"]==null)
             List<string> flowerlist = TempData["flowers"] as List<string>;
             TempData.Keep();
             return View(flowerlist); // passing an object Model
           // return RedirectToAction("Index");
        }
    }
}