using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using ArtGen.Models;
using System.Security.Cryptography;
using System.Text;

namespace ArtGen.Controllers
{
    public class UsuarioController : Controller
    {
        private arte_generoContext db = new arte_generoContext();

        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View(db.USUARIOs.ToList());
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.USUARIO user)
        {
            if (ModelState.IsValid)
            {
                if (IsValid(user.USERNAME, user.PASSWORD))
                {
                    FormsAuthentication.SetAuthCookie(user.USERNAME, user.Recordar);
                    return RedirectToAction("Index", "Pedido", new { id = user.USERNAME });
                }
                else
                {
                    ModelState.AddModelError("", "Usuario o Password erróneos!");
                }
            }
            return View(user);
        }

        public bool IsValid(string _username, string _password)
        {

         /*   TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(_username.ToString()));
            des.Mode = CipherMode.ECB;
            ICryptoTransform en = des.CreateEncryptor();

            
            byte[] buff = UnicodeEncoding.ASCII.GetBytes(_password);

            
            string retorno = Convert.ToBase64String(en.TransformFinalBlock(buff, 0, buff.Length));
          * 
          * */
            var consulta = (from u in db.USUARIOs
                            where _username == u.USERNAME &&
                            _password == u.PASSWORD
                            select u).Count();
            if (consulta > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(string id = null)
        {
            USUARIO usuario = db.USUARIOs.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                db.USUARIOs.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(string id = null)
        {
            USUARIO usuario = db.USUARIOs.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(string id = null)
        {
            USUARIO usuario = db.USUARIOs.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            USUARIO usuario = db.USUARIOs.Find(id);
            db.USUARIOs.Remove(usuario);
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