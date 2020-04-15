using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SERPROCI.Models;

namespace SERPROCI.Controllers
{
    public class UmdsController : Controller
    {
        private SERPROCIContext db = new SERPROCIContext();

        // GET: Umds
        public ActionResult Index()
        {
            return View(db.Umds.ToList());
        }

        // GET: Umds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Umd umd = db.Umds.Find(id);
            if (umd == null)
            {
                return HttpNotFound();
            }
            return View(umd);
        }

        // GET: Umds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Umds/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUmd,UmdName")] Umd umd)
        {
            if (ModelState.IsValid)
            {
                db.Umds.Add(umd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(umd);
        }

        // GET: Umds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Umd umd = db.Umds.Find(id);
            if (umd == null)
            {
                return HttpNotFound();
            }
            return View(umd);
        }

        // POST: Umds/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUmd,UmdName")] Umd umd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(umd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(umd);
        }

        // GET: Umds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Umd umd = db.Umds.Find(id);
            if (umd == null)
            {
                return HttpNotFound();
            }
            return View(umd);
        }

        // POST: Umds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Umd umd = db.Umds.Find(id);
            db.Umds.Remove(umd);
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
