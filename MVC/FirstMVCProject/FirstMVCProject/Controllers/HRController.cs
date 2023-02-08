using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCProject.Models;

namespace FirstMVCProject.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            List<Department> deptlist = new List<Department>()
            {
                new Department{DID=10, Dname="CSE"},
                new Department{DID=20, Dname="IT"},
                new Department{DID=30, Dname="ECE"},
                new Department{DID=40, Dname="Civil"},
                new Department{DID=50, Dname="Mech"},
            };
            // ViewName, Object Model
             return View("ListDepartment", deptlist);
            //return RedirectToAction("Sample");
           // return View("Sample");
        }

        public ActionResult ListDepartment(List<Department> dlist)
        {
            return View(dlist);
        }

        public ActionResult ListEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 1, Name = "Suraj", Age =32});
            emplist.Add(new Employee { Id = 2, Name = "Rajesh", Age = 30 });
            emplist.Add(new Employee { Id = 3, Name = "Bhushan", Age = 27 });
            emplist.Add(new Employee { Id = 4, Name = "Ajay", Age = 29 });

            return View(emplist);
        }

        public ActionResult ScaffoldedListEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 1, Name = "Suraj", Age = 32 });
            emplist.Add(new Employee { Id = 2, Name = "Rajesh", Age = 30 });
            emplist.Add(new Employee { Id = 3, Name = "Bhushan", Age = 27 });
            emplist.Add(new Employee { Id = 4, Name = "Ajay", Age = 29 });

            return View(emplist);
        }
        //display employee details using standard html tags viz table,list etc
        public ActionResult DisplayEmployee()
        {
            Employee e = new Employee() { Id = 100, Name = "Priya", Age = 26 };
            return View(e);

        }

        //display employee details using controls 
        [ActionName("Employee")]
        public ActionResult EmployeeData()
        {
            Employee e = new Employee() { Id = 25, Name = "Sandy", Age = 26 };
            return View(e);
        }

        [ActionName("Data")]
        public ActionResult Sample()
        {
            return View("Sample");
        }
    }
}