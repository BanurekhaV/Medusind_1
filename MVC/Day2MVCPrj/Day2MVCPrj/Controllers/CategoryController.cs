using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2MVCPrj.Models;

namespace Day2MVCPrj.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            //List<Category> category = db.Categories.ToList();
            //return View(category);  or as below 
            return View(db.Categories.ToList());
        }

        //fetch the category model data by name in ascending order
        //using query syntax
        public ActionResult GetCategoryByName()
        {
            var cname = from cat in db.Categories
                        orderby cat.CategoryName
                        select cat.CategoryName.ToString();
            return View(cname);
        }

        //get the same output as above by using method syntax

        public ActionResult GetCategoryByMethod()
        {
            dynamic cat = (db.Categories.OrderBy(c => c.CategoryName).Select(c1 => c1.CategoryName)).ToList();
            return View(cat);
        }

        //CRUD in Category
        //1. Create/Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
       // [ActionName("Create"]
       // 1. passing data as Model object from View to controller
        //public ActionResult Create(Category c)
        //{
        //    db.Categories.Add(c);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //2. Passing data as parameters (match the variables to the attributes of the table)
        //public ActionResult Create(string CategoryName,string Description)
        //{
        //    Category c = new Category();
        //   // c.CategoryID = Convert.ToInt32(CategoryID); identity column
        //    c.CategoryName = CategoryName;
        //    c.Description = Description;
        //    db.Categories.Add(c);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //3. Using Request Object
        [ActionName("Create")]
        public ActionResult CreatePost()
        {
            Category cat = new Category();
            cat.CategoryID = Convert.ToInt32(Request["CategoryID"]);
            cat.CategoryName = Request["CategoryName"].ToString();
            cat.Description = Request["Description"].ToString();
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // 2. Get category details for a given ID
        public ActionResult Details(int Id)
        {
            Category c = db.Categories.Find(Id);
            return View(c);
        }

        //3. Editing category
        public ActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            Category c = db.Categories.Find(cat.CategoryID);
            c.CategoryName = cat.CategoryName;
            c.Description = cat.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4. Deleting a row based on an ID

        public ActionResult Delete(int id)
        {
            Category c = db.Categories.Find(id);
            // return View(c);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Delete(Category c)
        //{
        //    db.Categories.Remove(c);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //5. procedure calls
        [ActionName("ExpensiveProducts")]
        public ActionResult Procedure_ExpensiveProducts()
        {
            return View("Procedure_ExpensiveProducts", db.Ten_Most_Expensive_Products());
        }
    }
}