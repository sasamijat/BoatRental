using BoatsMontenegro.AutorizationAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoatsMontenegro.Controllers
{
    public class OstaloController : Controller
    {                
        public ActionResult Kategorije()
        {
            return View();
        }

        [CustomAuthorize("Admin", "Buyer", "Seller")]
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

        
        public ActionResult NajcescaPitanja()
        {
            return View();
        }

        
        public ActionResult RecenzijeIskustva()
        {
            return View();
        }


    }
}