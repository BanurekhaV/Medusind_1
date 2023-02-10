using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3MVCPrj.Models;
using System.Data.Entity;
using System.Net;

namespace Day3MVCPrj.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Products

        //understand eager loading
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Supplier);
            return View(products.ToList());
        }

        //create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //for drop down
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName",product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName", product.SupplierID);

            return View(product);
        }

        //Edit 
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product p = db.Products.Find(id);
            if(p==null)
            {
                return HttpNotFound();
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", p.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName", p.SupplierID);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Product prod)
        {
            if(ModelState.IsValid)
            {
                db.Entry(prod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", prod.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName", prod.SupplierID);
            return View(prod);
        }

        //delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product p = db.Products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product p = db.Products.Find(id);
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}