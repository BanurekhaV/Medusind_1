using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Day4HtmlHelpersPrj.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        //1. Using standard html helpers for registration
        public ActionResult CreateRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegistration(FormCollection frm)
        {
            string name = frm["txtname"].ToString();
            string password = frm["txtpass"].ToString();
            string gender = frm["Gender"].ToString();

            bool music = Convert.ToBoolean(frm["M"].Split(',')[0]);
            bool sports = Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool arts = Convert.ToBoolean(frm["A"].Split(',')[0]);

            //to handle multiple check box selections
            string interest = "";
            //if (music == true)
            //    interest += "Music";
            //if (sports == true)
            //    interest += "Sports";
            //if (arts == true)
            //    interest += "Arts";

            string city = frm["City"].ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append(name + "<br/>");
            sb.Append(password + "<br/>");
            sb.Append(gender + "<br/>");
            sb.Append(city + "<br/>");
            sb.Append(interest + "<br/>");
            return Content(sb.ToString());
        }
    }
}