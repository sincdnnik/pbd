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
    public class FotoController : Controller
    {
        private arte_generoContext db = new arte_generoContext();

        //
        // GET: /Foto/
        
        public ActionResult Index(int id)
        {
            /*string query = "SELECT F.URL_FOTOGRAFIA , D.NOMBRE_DISENO FROM FOTOGRAFIA F, DISENO D, CATEGORIZACION CZ, CATEGORIA C " +
                "WHERE F.ID_FOTOGRAFIA = D.ID_FOTOGRAFIA AND D.ID_DISENO = CZ.ID_DISENO AND CZ.ID_CATEGORIA = C.ID_CATEGORIA AND " +
                " C.ID_CATEGORIA = '" + id + "';";

                
            var RESULT = db.Database.ExecuteSqlCommand(query);
             * 
             * DataSet ds = new DataSet();
            SqlCommand cmd = (SqlCommand)db.GetCommand(consulta);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
             
             return View(RESULT);
             */

            //CONSULTA LINQ TO SQL VALIDA, DEVUELVE SOLO URL_FOTO y parece q tb nombre_diseño


            ViewBag.consulta_diseno = (from f in db.FOTOGRAFIAs
                                       from d in db.DISENOes
                                       from catz in db.CATEGORIZACIONs
                                       from cat in db.CATEGORIAs
                                       where f.ID_DISENO == d.ID_DISENO &&
                                       d.ID_DISENO == catz.ID_DISENO &&
                                       catz.ID_CATEGORIA == cat.ID_CATEGORIA &&
                                       cat.ID_CATEGORIA == id
                                       select d.NOMBRE_DISENO).ToList();
            ViewBag.consulta_foto = (from f in db.FOTOGRAFIAs
                                     from d in db.DISENOes
                                     from catz in db.CATEGORIZACIONs
                                     from cat in db.CATEGORIAs
                                     where f.ID_DISENO == d.ID_DISENO &&
                                     d.ID_DISENO == catz.ID_DISENO &&
                                     catz.ID_CATEGORIA == cat.ID_CATEGORIA &&
                                     cat.ID_CATEGORIA == id
                                     select f.URL_FOTOGRAFIA).ToList();

            ViewBag.cuenta = (from f in db.FOTOGRAFIAs
                              from d in db.DISENOes
                              from catz in db.CATEGORIZACIONs
                              from cat in db.CATEGORIAs
                              where f.ID_DISENO == d.ID_DISENO &&
                              d.ID_DISENO == catz.ID_DISENO &&
                              catz.ID_CATEGORIA == cat.ID_CATEGORIA &&
                              cat.ID_CATEGORIA == id
                              select d.NOMBRE_DISENO).Count();
      /*      ViewBag.nfot = (from c in db.CATEGORIAs
                                from catz in db.CATEGORIZACIONs
                                from d in db.DISENOes
                                from f in db.FOTOGRAFIAs
                                where id == c.ID_CATEGORIA &
                                c.ID_CATEGORIA == catz.ID_CATEGORIA &&
                                catz.ID_DISENO == d.ID_DISENO &&
                                d.ID_FOTOGRAFIA == f.ID_FOTOGRAFIA).ToList();
            /*if (consulta == null)
            {
                return HttpNotFound();
            }
        */
            return View();

            //CONSULTA LINQ TO SQL HACIENDO JOIN A LAS TABLAS
            /* var consulta = from f in db.FOTOGRAFIAs
                            join d in db.DISENOes on f.ID_FOTOGRAFIA equals d.ID_FOTOGRAFIA
                            join catz in db.CATEGORIZACIONs on d.ID_DISENO equals catz.ID_DISENO
                            join c in db.CATEGORIAs on catz.ID_CATEGORIA equals c.ID_CATEGORIA
                            where c.ID_CATEGORIA == id
                            select new
                            {
                                f.URL_FOTOGRAFIA,
                                d.NOMBRE_DISENO
                            };
           
             */




        }
        
   /*   public ActionResult Index()
        {
            var fotografias = db.FOTOGRAFIAs.Include(f => f.DISENO);
            return View(fotografias.ToList());
        }*/

        //
        // GET: /Foto/Details/5

        public ActionResult Details(int id = 0)
        {
            FOTOGRAFIA fotografia = db.FOTOGRAFIAs.Find(id);
            if (fotografia == null)
            {
                return HttpNotFound();
            }
            return View(fotografia);
        }

        //
        // GET: /Foto/Create

        public ActionResult Create()
        {
            ViewBag.ID_DISENO = new SelectList(db.DISENOes, "ID_DISENO", "NOMBRE_DISENO");
            return View();
        }

        //
        // POST: /Foto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FOTOGRAFIA fotografia)
        {
            if (ModelState.IsValid)
            {
                db.FOTOGRAFIAs.Add(fotografia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_DISENO = new SelectList(db.DISENOes, "ID_DISENO", "NOMBRE_DISENO", fotografia.ID_DISENO);
            return View(fotografia);
        }

        //
        // GET: /Foto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FOTOGRAFIA fotografia = db.FOTOGRAFIAs.Find(id);
            if (fotografia == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DISENO = new SelectList(db.DISENOes, "ID_DISENO", "NOMBRE_DISENO", fotografia.ID_DISENO);
            return View(fotografia);
        }

        //
        // POST: /Foto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FOTOGRAFIA fotografia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fotografia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_DISENO = new SelectList(db.DISENOes, "ID_DISENO", "NOMBRE_DISENO", fotografia.ID_DISENO);
            return View(fotografia);
        }

        //
        // GET: /Foto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FOTOGRAFIA fotografia = db.FOTOGRAFIAs.Find(id);
            if (fotografia == null)
            {
                return HttpNotFound();
            }
            return View(fotografia);
        }

        //
        // POST: /Foto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FOTOGRAFIA fotografia = db.FOTOGRAFIAs.Find(id);
            db.FOTOGRAFIAs.Remove(fotografia);
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