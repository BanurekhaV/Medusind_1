using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4HtmlHelpersPrj.Models;

namespace Day4HtmlHelpersPrj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. Strongly Typed Helper
        public ActionResult stronglyTyped()
        {
            return View();
        }

        //2. Templated Helper
        public ActionResult templatedHelper()
        {
            return View();
        }

        //3. Editor for Helper
        public ActionResult EditorForModel()
        {
            return View();
        }

        //4. Custom Helpers
        public ActionResult CustomHelper()
        {
            return View();
        }
    }
}