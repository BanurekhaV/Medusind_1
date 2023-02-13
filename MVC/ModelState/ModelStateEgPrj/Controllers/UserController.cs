using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateEgPrj.Models;

namespace ModelStateEgPrj.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserStatus()
        {
            ViewBag.status = "Validation Successful";
            return View();
        }

        [HttpGet]
        public ActionResult CheckUser()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult CheckUser(User u)
        {
            if(string.IsNullOrEmpty(u.ULname))
            {
                ModelState.AddModelError("Lastname", "Last Name is required");
            }
            if(u.Age<18 || u.Age>60)
            {
                ModelState.AddModelError("Age", "Age to be between 18 and 60 only");
            }
            if(!ModelState.IsValid)
            {
                return View(u);
            }
            else
            {
                TempData["fname"] = u.UFname;
                TempData["lname"] = u.ULname;
                TempData["age"] = u.Age;
                TempData["mail"] = u.Email;
                TempData.Keep();
                return RedirectToAction("UserStatus");
            }
        }
    }
}