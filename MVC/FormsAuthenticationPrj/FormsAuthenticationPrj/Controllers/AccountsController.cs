using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FormsAuthenticationPrj.Models;

namespace FormsAuthenticationPrj.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        //For Login
        public ActionResult Login()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using(SecurityDBEntities db=new SecurityDBEntities())
            {
                bool IsValidUser = db.Users.Any(u => u.UserName.ToLower() ==
                 user.UserName.ToLower() && u.UserPassword == user.UserPassword);

                //if(!IsValidUser)
                //{
                //    ModelState.AddModelError("", "Invalid Username or Password");
                //    return View();
                //}
                //else
                //    FormsAuthentication.SetAuthCookie(user.UserName, false);
                //return RedirectToAction("welcome");
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                      return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "Invalid UserName or Password");
                
                return View();
            }
        }

        public ActionResult welcome()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Signup(User user)
        {
            using(SecurityDBEntities db= new SecurityDBEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}