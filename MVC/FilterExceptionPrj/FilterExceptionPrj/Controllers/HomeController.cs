using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterExceptionPrj.Models;


namespace FilterExceptionPrj.Controllers
{
    //Home controller created out of empty template
    //[HandleError(ExceptionType =typeof(DivideByZeroException),View ="DivideByZero")]
    //[HandleError(ExceptionType = typeof(NullReferenceException), View = "NullReference")]
  //  [HandleError]
      
    public class HomeController : Controller
    {
        // GET: Home
       // [HandleError]
        public ActionResult Index()
        {
            //throw new Exception("Some Error Occured..");
            throw new NullReferenceException();
            //return View();
        }
           [CustomLogsFilter]
        public ActionResult DivideMethod()
        {
            throw new DivideByZeroException();
        }
    }
}