using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoatsMontenegro.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult AboutUsMasterpage()
        {
            return PartialView();
        }

        public ActionResult AboutUsPage()
        {
            return View();
        }

    }
}