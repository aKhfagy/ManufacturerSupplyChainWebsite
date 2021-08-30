using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using API;

namespace API.Controllers
{
    public class RequsetsController : Controller
    {
        private ManufacturerEntities db = new ManufacturerEntities();

        // GET: Requsets
        public ActionResult Index()
        {
            return View(db.Requsets.ToList());
        }

        // GET: Requsets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requset requset = db.Requsets.Find(id);
            if (requset == null)
            {
                return HttpNotFound();
            }
            return View(requset);
        }

        // GET: Requsets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requsets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyID,Company_Name,ItemID,Item_Name,Item_Quantity,Pick_Up_Date,Purchaise_Price,Shipping_instructions,Recurring_Order")] Requset requset)
        {
            if (ModelState.IsValid)
            {
                db.Requsets.Add(requset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requset);
        }

        // GET: Requsets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requset requset = db.Requsets.Find(id);
            if (requset == null)
            {
                return HttpNotFound();
            }
            return View(requset);
        }

        // POST: Requsets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyID,Company_Name,ItemID,Item_Name,Item_Quantity,Pick_Up_Date,Purchaise_Price,Shipping_instructions,Recurring_Order")] Requset requset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requset);
        }

        // GET: Requsets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requset requset = db.Requsets.Find(id);
            if (requset == null)
            {
                return HttpNotFound();
            }
            return View(requset);
        }

        // POST: Requsets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Requset requset = db.Requsets.Find(id);
            db.Requsets.Remove(requset);
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
