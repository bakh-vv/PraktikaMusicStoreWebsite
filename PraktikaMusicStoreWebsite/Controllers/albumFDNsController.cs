using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PraktikaMusicStoreWebsite.Models;

namespace PraktikaMusicStoreWebsite.Controllers
{
    public class albumFDNsController : Controller
    {
        private StoreContextFDN db = new StoreContextFDN();

        // GET: albumFDNs
        //[Authorize()]
        public ActionResult Index()
        {
            return View(db.albumFDNs.ToList());
        }

        // GET: albumFDNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            albumFDN albumFDN = db.albumFDNs.Find(id);
            if (albumFDN == null)
            {
                return HttpNotFound();
            }
            return View(albumFDN);
        }

        // GET: albumFDNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: albumFDNs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "albumFDNID,Name,Year,Duration,artistID,Availability,typeID,Price")] albumFDN albumFDN)
        {
            if (ModelState.IsValid)
            {
                db.albumFDNs.Add(albumFDN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(albumFDN);
        }

        // GET: albumFDNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            albumFDN albumFDN = db.albumFDNs.Find(id);
            if (albumFDN == null)
            {
                return HttpNotFound();
            }
            return View(albumFDN);
        }

        // POST: albumFDNs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "albumFDNID,Name,Year,Duration,artistID,Availability,typeID,Price")] albumFDN albumFDN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(albumFDN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(albumFDN);
        }

        // GET: albumFDNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            albumFDN albumFDN = db.albumFDNs.Find(id);
            if (albumFDN == null)
            {
                return HttpNotFound();
            }
            return View(albumFDN);
        }

        // POST: albumFDNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            albumFDN albumFDN = db.albumFDNs.Find(id);
            db.albumFDNs.Remove(albumFDN);
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
