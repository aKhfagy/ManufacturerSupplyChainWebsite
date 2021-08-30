using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using API;
using API.Models;

namespace API.Controllers
{
    public class ManufacturerProfilesController : Controller
    {
        private ManufacturerEntities1 db = new ManufacturerEntities1();

        // GET: ManufacturerProfiles
        public ActionResult Index()
        {
            return View(db.ManufacturerProfiles.ToList());
        }

        // GET: ManufacturerProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManufacturerProfile manufacturerProfile = db.ManufacturerProfiles.Find(id);
            if (manufacturerProfile == null)
            {
                return HttpNotFound();
            }
            return View(manufacturerProfile);
        }

        // GET: ManufacturerProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManufacturerProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,Description,Name,Email,PhoneNumber,NumberOfProducts")] ManufacturerProfile manufacturerProfile)
        {
            if (ModelState.IsValid)
            {
                db.ManufacturerProfiles.Add(manufacturerProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturerProfile);
        }

        // GET: ManufacturerProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManufacturerProfile manufacturerProfile = db.ManufacturerProfiles.Find(id);
            if (manufacturerProfile == null)
            {
                return HttpNotFound();
            }
            return View(manufacturerProfile);
        }

        // POST: ManufacturerProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image,Description,Name,Email,PhoneNumber,NumberOfProducts")] ManufacturerProfile manufacturerProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturerProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturerProfile);
        }

        // GET: ManufacturerProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManufacturerProfile manufacturerProfile = db.ManufacturerProfiles.Find(id);
            if (manufacturerProfile == null)
            {
                return HttpNotFound();
            }
            return View(manufacturerProfile);
        }

        // POST: ManufacturerProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManufacturerProfile manufacturerProfile = db.ManufacturerProfiles.Find(id);
            db.ManufacturerProfiles.Remove(manufacturerProfile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
