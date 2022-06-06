using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.Models;
using BoatsMontenegro.BaseBase;
using BoatsMontenegro.AutorizationAuthentication;

namespace BoatsMontenegro.Controllers 
{
    public class PonudaController : Controller
    {
        BaseContext objContext;
        public PonudaController()
        {
            objContext = new BaseContext();
        }

        //[CustomAuthorize("Admin", "Buyer", "Seller")]
        public ActionResult ShowOne(string id)   /*string id*/
        {
            int BoatId = Int32.Parse(id);

            var boats = objContext.Boats.Where(b => b.BoatID == BoatId).ToList();
            return View(boats.Take(6));
        }

        //[CustomAuthorize("Admin", "Buyer", "Seller")]
        public ViewResult WholeOffer(string search)   /*string*/
        {
            var boats123 = objContext.Boats.ToList();

            if (search != null)
            {
                //boats = boats.Where(x => x.Size.Contains(search) || x.Category.Contains(search)).ToList();
                return View(objContext.Boats.Where(x => x.Size.Contains(search) 
                && x.Capacity.ToString().Contains(search) && x.Price.ToString().Contains(search)).ToList());
            }
            return View(objContext.Boats);        
        }

        public ActionResult SearchFunc(string search)
        {
            return View(objContext.Boats.Where(x => x.Name.Contains(search)).ToList());
        }
        //public ViewResult SearchOffer(string searchString)
        //{
        //    var boatsOff = from s in objContext.Boats select s;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        boatsOff = boatsOff.Where(s => s.Capacity.ToString().Contains(searchString) || s.Size.Contains(searchString));
        //    }
        //    return View(boatsOff.ToList());
        //}


        [HttpGet]
        public ActionResult Kategorije(string category)
        {
            var boats = objContext.Boats.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

            return View(viewName: "WholeOffer", boats);
        }

        [CustomAuthorize("Admin","Seller")]
        public ActionResult PublishYourBoat()
        {
            return View();
        }

    }
}
