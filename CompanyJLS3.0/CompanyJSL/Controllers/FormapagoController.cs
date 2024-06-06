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
    public class FormapagoController : Controller
    {
        private Company_JLS_nuevaEntities2 db = new Company_JLS_nuevaEntities2();

        // GET: Formapago
        public ActionResult Index()
        {
            return View(db.Forma_de_pago.ToList());
        }

        // GET: Formapago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forma_de_pago forma_de_pago = db.Forma_de_pago.Find(id);
            if (forma_de_pago == null)
            {
                return HttpNotFound();
            }
            return View(forma_de_pago);
        }

        // GET: Formapago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formapago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Numerodepago,Efectivo,Tarjeta,Número_de_tarjeta")] Forma_de_pago forma_de_pago)
        {
            if (ModelState.IsValid)
            {
                db.Forma_de_pago.Add(forma_de_pago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forma_de_pago);
        }

        // GET: Formapago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forma_de_pago forma_de_pago = db.Forma_de_pago.Find(id);
            if (forma_de_pago == null)
            {
                return HttpNotFound();
            }
            return View(forma_de_pago);
        }

        // POST: Formapago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Numerodepago,Efectivo,Tarjeta,Número_de_tarjeta")] Forma_de_pago forma_de_pago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(forma_de_pago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(forma_de_pago);
        }

        // GET: Formapago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forma_de_pago forma_de_pago = db.Forma_de_pago.Find(id);
            if (forma_de_pago == null)
            {
                return HttpNotFound();
            }
            return View(forma_de_pago);
        }

        // POST: Formapago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Forma_de_pago forma_de_pago = db.Forma_de_pago.Find(id);
            db.Forma_de_pago.Remove(forma_de_pago);
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
