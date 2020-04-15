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
    public class TipoServicioController : Controller
    {
        private SERPROCIContext db = new SERPROCIContext();

        // GET: TipoServicio
        public ActionResult Index()
        {
            var tipoServicios = db.TipoServicios.Include(t => t.Empresa);
            return View(tipoServicios.ToList());
        }

        // GET: TipoServicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServicio tipoServicio = db.TipoServicios.Find(id);
            if (tipoServicio == null)
            {
                return HttpNotFound();
            }
            return View(tipoServicio);
        }

        // GET: TipoServicio/Create
        public ActionResult Create()
        {
            ViewBag.IdEmpresa = new SelectList(db.Empresas, "IdEmpresa", "EmpresaName");
            return View();
        }

        // POST: TipoServicio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoServicio,IdEmpresa,TipoServicioName")] TipoServicio tipoServicio)
        {
            if (ModelState.IsValid)
            {
                db.TipoServicios.Add(tipoServicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEmpresa = new SelectList(db.Empresas, "IdEmpresa", "EmpresaName", tipoServicio.IdEmpresa);
            return View(tipoServicio);
        }

        // GET: TipoServicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServicio tipoServicio = db.TipoServicios.Find(id);
            if (tipoServicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEmpresa = new SelectList(db.Empresas, "IdEmpresa", "EmpresaName", tipoServicio.IdEmpresa);
            return View(tipoServicio);
        }

        // POST: TipoServicio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoServicio,IdEmpresa,TipoServicioName")] TipoServicio tipoServicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoServicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEmpresa = new SelectList(db.Empresas, "IdEmpresa", "EmpresaName", tipoServicio.IdEmpresa);
            return View(tipoServicio);
        }

        // GET: TipoServicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServicio tipoServicio = db.TipoServicios.Find(id);
            if (tipoServicio == null)
            {
                return HttpNotFound();
            }
            return View(tipoServicio);
        }

        // POST: TipoServicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoServicio tipoServicio = db.TipoServicios.Find(id);
            db.TipoServicios.Remove(tipoServicio);
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
