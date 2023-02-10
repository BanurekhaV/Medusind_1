using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelPrj.Models;
using ViewModelPrj.ViewModels;

namespace ViewModelPrj.Controllers
{
    [RoutePrefix("cust")]
    public class CustOrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: CustOrder
        [Route("start")]
        public ActionResult Index()
        {
            return View();
        }

        //populating data into Viewmodel
        [Route("getorders")]
        public ActionResult CustomerOrders()
        {
            List<CustomerVM> custvmlist = new List<CustomerVM>();
            //query to get the details from the database joining 2 tables
            var custlist = (from cust in db.Customers
                            join ord in db.Orders
                            on cust.CustomerID equals ord.CustomerID
                            select new
                            {
                                cust.CustomerID,
                                cust.CompanyName,
                                cust.ContactName,
                                ord.OrderID,
                                ord.OrderDate
                            }).ToList();

            //using loop , we will fill the data into the Viewmodel class List object
            foreach(var v in custlist)
            {
                CustomerVM cvmobj = new CustomerVM(); //viemodel class object
                cvmobj.CustomerID = v.CustomerID;
                cvmobj.CompanyName = v.CompanyName;
                cvmobj.ContactName = v.ContactName;
                cvmobj.OrderID = v.OrderID;
                cvmobj.OrderDate = v.OrderDate;

                custvmlist.Add(cvmobj);
            }
            return View(custvmlist);

        }
    }
}