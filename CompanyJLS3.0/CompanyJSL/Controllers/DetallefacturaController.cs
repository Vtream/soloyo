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
    public class DetallefacturaController : Controller
    {
        private Company_JLS_nuevaEntities2 db = new Company_JLS_nuevaEntities2();

        // GET: Detallefactura
        public ActionResult Index()
        {
            return View(db.Detalle_Factura.ToList());
        }

        // GET: Detallefactura/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Factura detalle_Factura = db.Detalle_Factura.Find(id);
            if (detalle_Factura == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Factura);
        }

        // GET: Detallefactura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detallefactura/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Cantidad,Valor,CodigoPlato")] Detalle_Factura detalle_Factura)
        {
            if (ModelState.IsValid)
            {
                db.Detalle_Factura.Add(detalle_Factura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detalle_Factura);
        }

        // GET: Detallefactura/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Factura detalle_Factura = db.Detalle_Factura.Find(id);
            if (detalle_Factura == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Factura);
        }

        // POST: Detallefactura/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Cantidad,Valor,CodigoPlato")] Detalle_Factura detalle_Factura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalle_Factura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detalle_Factura);
        }

        // GET: Detallefactura/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Factura detalle_Factura = db.Detalle_Factura.Find(id);
            if (detalle_Factura == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Factura);
        }

        // POST: Detallefactura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Detalle_Factura detalle_Factura = db.Detalle_Factura.Find(id);
            db.Detalle_Factura.Remove(detalle_Factura);
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
