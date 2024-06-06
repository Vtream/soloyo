using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompanyJSL.Models;

namespace CompanyJSL.Controllers
{
    public class DetallestarjetasController : Controller
    {
        private Company_JLS_nuevaEntities2 db = new Company_JLS_nuevaEntities2();

        // GET: Detallestarjetas
        public ActionResult Index()
        {
            return View(db.Detalles_tarjetas.ToList());
        }

        // GET: Detallestarjetas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_tarjetas detalles_tarjetas = db.Detalles_tarjetas.Find(id);
            if (detalles_tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(detalles_tarjetas);
        }

        // GET: Detallestarjetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detallestarjetas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Número_de_tarjeta,Nombre_Titular,Fecha_de_vencimiento,CVV")] Detalles_tarjetas detalles_tarjetas)
        {
            if (ModelState.IsValid)
            {
                db.Detalles_tarjetas.Add(detalles_tarjetas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detalles_tarjetas);
        }

        // GET: Detallestarjetas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_tarjetas detalles_tarjetas = db.Detalles_tarjetas.Find(id);
            if (detalles_tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(detalles_tarjetas);
        }

        // POST: Detallestarjetas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Número_de_tarjeta,Nombre_Titular,Fecha_de_vencimiento,CVV")] Detalles_tarjetas detalles_tarjetas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalles_tarjetas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detalles_tarjetas);
        }

        // GET: Detallestarjetas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_tarjetas detalles_tarjetas = db.Detalles_tarjetas.Find(id);
            if (detalles_tarjetas == null)
            {
                return HttpNotFound();
            }
            return View(detalles_tarjetas);
        }

        // POST: Detallestarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Detalles_tarjetas detalles_tarjetas = db.Detalles_tarjetas.Find(id);
            db.Detalles_tarjetas.Remove(detalles_tarjetas);
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
