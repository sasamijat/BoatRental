using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoatsMontenegro.Controllers
{
    public class OstaloController : Controller
    {
        // GET: Ostalo
        [Authorize]
        public ActionResult Kategorije()
        {
            return View();
        }
        [Authorize]
        public ActionResult IznajmiSvojBrod()
        {
            return View();
        }
        //[Authorize]
        public ActionResult NaciniPlacanja()
        {
            return View();
        }
        //[Authorize]
        public ActionResult Kontakt()
        {
            return View();
        }
        [Authorize]
        public ActionResult NajcescaPitanja()
        {
            return View();
        }
        [Authorize]
        public ActionResult RecenzijeIskustva()
        {
            return View();
        }


    }
}