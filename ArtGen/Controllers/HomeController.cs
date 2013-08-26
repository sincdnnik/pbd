using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtGen.Models;

namespace ArtGen.Controllers
{
    public class HomeController : Controller
    {

        private arte_generoContext db = new arte_generoContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult Catalogo()
        {
            return View(db.CATEGORIAs.ToList());
        }

    }
}
