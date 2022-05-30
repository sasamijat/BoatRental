using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoatsMontenegro.Controllers
{
    public class OstaloController : Controller
    {
        
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
        
        public ActionResult NaciniPlacanja()
        {
            return View();
        }
        
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