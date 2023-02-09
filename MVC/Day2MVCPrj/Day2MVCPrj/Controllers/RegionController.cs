using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2MVCPrj.Models;
using System.Net;
using System.Data.Entity;


namespace Day2MVCPrj.Controllers
{
    public class RegionController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Region
        public ActionResult Index()
        {
            return View(ne.Regions.ToList());
        }

        //details with check
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region r = ne.Regions.Find(id);
            if(r==null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        //Regions/create
        public ActionResult Create()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include ="RegionID, RegionDescription")] Region r)
        {
            if (ModelState.IsValid)
            {
                ne.Regions.Add(r);
                ne.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(r);
        }

        //Entity State
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Region reg = ne.Regions.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Region reg)
        {
            if (ModelState.IsValid)
            {
                ne.Entry(reg).State = EntityState.Modified;
                    ne.SaveChanges();
                    return RedirectToAction("Index");           
                           
            }
            return View(reg);

        }        
    }
}