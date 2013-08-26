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
    public class CatalogoController : Controller
    {
        private arte_generoContext db = new arte_generoContext();

        //
        // GET: /Catalogo/

        public ActionResult Index()
        {
            return View(db.CATEGORIAs.ToList());
        }

        //
        // GET: /Catalogo/Details/5

        public ActionResult Details(int id = 0)
        {
            CATEGORIA categoria = db.CATEGORIAs.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        //
        // GET: /Catalogo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Catalogo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CATEGORIA categoria)
        {
            if (ModelState.IsValid)
            {
                db.CATEGORIAs.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        //
        // GET: /Catalogo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CATEGORIA categoria = db.CATEGORIAs.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        //
        // POST: /Catalogo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CATEGORIA categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        //
        // GET: /Catalogo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CATEGORIA categoria = db.CATEGORIAs.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        //
        // POST: /Catalogo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CATEGORIA categoria = db.CATEGORIAs.Find(id);
            db.CATEGORIAs.Remove(categoria);
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