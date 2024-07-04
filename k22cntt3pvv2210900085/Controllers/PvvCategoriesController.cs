 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PvvK22CNT3Lesson11_2210900085.Models;

namespace PvvK22PvvK22CNT3_Lesson11Entities db = new PvvK22CNT3_Lesson11Entities();

        // GET: PvvCategories
        public ActionResult PvvIndex()
        {
            return View(db.PvvCategories.ToList());
        }

        // GET: PvvCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvCategory PvvCategory = db.PvvCategories.Find(id);
            if (PvvCategory == null)
            {
                return HttpNotFoundPvvCategory)
        {
            if (ModelState.IsValid)
            {
                db.PvvCategories.Add(PvvCategory);
                db.SaveChanges();
                return RedirectToAction("PvvIndex");
            }

            return View(PvvCategory);
        }

        // GET: PvvPvvCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            ifPvvCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PvvIndex");
            }
            return View(PvvCategory);
        }

        // GET: PvvCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvCategory PvvCategory = db.PvvCategories.Find(id);
            if (PvvCategory == null)
            {
                return HttpNotFound();
            }
            return View(PvvCategory);
        }

        // POST: PvvCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LHLCategory PvvCategory = db.PvvCategories.Find(id);
            db.PvvCategories.Remove(PvvCategory);
            db.SaveChanges();
            return RedirectToAction("PvvIndex");
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
