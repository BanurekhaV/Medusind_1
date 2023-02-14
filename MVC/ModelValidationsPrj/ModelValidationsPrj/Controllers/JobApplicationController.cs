using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelValidationsPrj.Controllers
{
    
    public class JobApplicationController : Controller
    {
        // GET: JobApplication       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.JobApplication JA)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Result = "Application Submitted Successfully";
            }
            else
                ViewBag.Result = "Invalid Data Provided.. Please Re Enter";
            return View();
        }

        
    }
}