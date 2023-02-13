using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4Prj.Models;

namespace Day4Prj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmpId = 1,
                EmpName = "Sukesh",
                Department = "Accounts",
                Salary = 45000,
            };
            ViewBag.Heading = "Employee Details";
            return View(employee);

        }

        public ActionResult Edit()
        {
            Employee employee = new Employee()
            {
                EmpId = 2,
                EmpName = "Abhishek",
                Department = "Operations",
                Salary = 45000,
            };
            ViewData["heading"] = "Employee Data";
            return View(employee);
        }

        public ActionResult FullEmployeeData()
        {
            Employee emp = new Employee()
            {
                EmpId = 100,
                EmpName = "Banurekha",
                Department = "IT",
                Salary = 45000
            };

            Address add = new Address()
            {
                AddressId = 1,
                City = "Mangalore",
                State = "Karnataka",
                Country = "India"
            };

            //create a viewmodel object
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = emp,
                address = add,
                PageTitle = "Employee Personal Details"
            };

            return View(empadd);
        }
    }
}