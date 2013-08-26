using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtGen.Models;

namespace ArtGen.Controllers
{
    public class PedidoController : Controller
    {
        private arte_generoContext db = new arte_generoContext();

        //
        // GET: /Pedido/
/*
        public ActionResult Index()
        {
            var reporte_produccion = db.REPORTE_PRODUCCION.Include(r => r.INCLUSION);
            return View(reporte_produccion.ToList());
        }
*/
        public ActionResult Index(int id)
        {
            ViewBag.info = (from cl in db.CLIENTEs
                           from os in db.ORDEN_DE_SERVICIO
                           from inc in db.INCLUSIONs
                           from rp in db.REPORTE_PRODUCCION
                           where id == cl.RUT &&
                           cl.RUT == os.RUT &
                           os.ID_OS == inc.ID_OS &&
                           inc.ID_OS == rp.ID_OS
                           select rp.INFORMACION_PRODUCCION).ToList();

            ViewBag.orden = (from cl in db.CLIENTEs
                            from os in db.ORDEN_DE_SERVICIO
                                 where id == cl.RUT &&
                                 cl.RUT == os.RUT
                                 select os.ID_OS).ToList();

            ViewBag.cuentaos = (from cl in db.CLIENTEs
                                from os in db.ORDEN_DE_SERVICIO
                                where id == cl.RUT &&
                                cl.RUT == os.RUT
                                select os.ID_OS).Count();
            return View();
                           
        }
        //
        // GET: /Pedido/Details/5

        public ActionResult Details(int id = 0)
        {
            REPORTE_PRODUCCION reporte_produccion = db.REPORTE_PRODUCCION.Find(id);
            if (reporte_produccion == null)
            {
                return HttpNotFound();
            }
            return View(reporte_produccion);
        }

        //
        // GET: /Pedido/Create

        public ActionResult Create()
        {
            ViewBag.ID_OS = new SelectList(db.INCLUSIONs, "ID_OS", "COLOR");
            return View();
        }

        //
        // POST: /Pedido/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(REPORTE_PRODUCCION reporte_produccion)
        {
            if (ModelState.IsValid)
            {
                db.REPORTE_PRODUCCION.Add(reporte_produccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_OS = new SelectList(db.INCLUSIONs, "ID_OS", "COLOR", reporte_produccion.ID_OS);
            return View(reporte_produccion);
        }

        //
        // GET: /Pedido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            REPORTE_PRODUCCION reporte_produccion = db.REPORTE_PRODUCCION.Find(id);
            if (reporte_produccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_OS = new SelectList(db.INCLUSIONs, "ID_OS", "COLOR", reporte_produccion.ID_OS);
            return View(reporte_produccion);
        }

        //
        // POST: /Pedido/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(REPORTE_PRODUCCION reporte_produccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reporte_produccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_OS = new SelectList(db.INCLUSIONs, "ID_OS", "COLOR", reporte_produccion.ID_OS);
            return View(reporte_produccion);
        }

        //
        // GET: /Pedido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            REPORTE_PRODUCCION reporte_produccion = db.REPORTE_PRODUCCION.Find(id);
            if (reporte_produccion == null)
            {
                return HttpNotFound();
            }
            return View(reporte_produccion);
        }

        //
        // POST: /Pedido/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REPORTE_PRODUCCION reporte_produccion = db.REPORTE_PRODUCCION.Find(id);
            db.REPORTE_PRODUCCION.Remove(reporte_produccion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}