using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PvvK22CNT3Lesson11_2210900085.Models;

namespace PvvK22CNT3Lesson11_2210900085.Controllers
{
    public class PvvProductsController : Controller
    {
        private PvvK22CNT3_Lesson11Entities db = new PvvK22CNT3_Lesson11Entities();

        // GET: PvvProducts
        public ActionResult PvvIndex()
        {
            var PvvProducts = db.PvvProducts.Include(l => l.PvvCategory);
            return View(PvvProducts.ToList());
        }

        // GET: PvvProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvProduct PvvProduct = db.PvvProducts.Find(id);
            if (PvvProduct == null)
            {
                return HttpNotFound();
            }
            rePvvCateId);
            return View(PvvProduct);
        }

        // GET: PvvPvvProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeRPvvProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PvvIndex");
            }
            ViewBag.PvvCateId = new SelectList(db.PvvCategories, "PvvId", "PvvCateName", PvvProduct.PvvCateId);
            return View(PvvProduct);
        }

        // GET: PvvProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvProduct PvvProduct = db.PvvProducts.Find(id);
            if (PvvProduct == null)
            {
                return HttpNotFound();
            }
            return View(PvvProduct);
        }

        // POST: PvvPvvProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PvvProduct PvvProduct = db.PvvProducts.Find(id);
            db.PvvProducts.Remove(PvvProduct);
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
