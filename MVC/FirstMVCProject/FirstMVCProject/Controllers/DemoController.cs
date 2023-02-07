using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCProject.Models;

namespace FirstMVCProject.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal Method
        public string NormalMethod()
        {
            return "Hello All";
        }

        //2. Content result
        public ContentResult ContentMethod()
        {
            // return Content("Good Evening !!", "text/plain");
            return Content("<h1>Good Evening !!");
        }

        //3. EmptyResult

        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float SI = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //4. JsonResult
        public JsonResult JsonMethod()
        {
            Employee emp = new Employee();
            emp.Id = 10;
            emp.Name = "Sunil";
            emp.Age = 25;
            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        //5. ViewResult
        public ViewResult ViewMethod()
        {
            return View();
        }
    }
}