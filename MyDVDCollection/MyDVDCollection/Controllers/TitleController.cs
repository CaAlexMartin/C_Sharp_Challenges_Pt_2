using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyDVDCollection.DataAccess;
using MyDVDCollection.Models;

namespace MyDVDCollection.Controllers
{
    public class TitleController : Controller
    {
        private DVDContext db = new DVDContext();

        // GET: Title
        public ActionResult Index()
        {
            return View(db.Titles.ToList());
        }

        // GET: Title/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titles titles = db.Titles.Find(id);
            if (titles == null)
            {
                return HttpNotFound();
            }
            return View(titles);
        }

        // GET: Title/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Title/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,PurchaseDate")] Titles titles)
        {
            if (ModelState.IsValid)
            {
                db.Titles.Add(titles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titles);
        }

        // GET: Title/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titles titles = db.Titles.Find(id);
            if (titles == null)
            {
                return HttpNotFound();
            }
            return View(titles);
        }

        // POST: Title/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,PurchaseDate")] Titles titles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titles);
        }

        // GET: Title/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titles titles = db.Titles.Find(id);
            if (titles == null)
            {
                return HttpNotFound();
            }
            return View(titles);
        }

        // POST: Title/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Titles titles = db.Titles.Find(id);
            db.Titles.Remove(titles);
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
