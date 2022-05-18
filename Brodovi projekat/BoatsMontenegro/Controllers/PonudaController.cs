using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.Models;
using BoatsMontenegro.BaseBase;

namespace BoatsMontenegro.Controllers 
{
    public class PonudaController : Controller
    {
        BaseContext objContext;
        public PonudaController()
        {
            objContext = new BaseContext();
        }
        public ActionResult ShowOne(string id)   /*string id*/
        {
            int BoatId = Int32.Parse(id);

            var boats = objContext.Boats.Where(b => b.BoatID == BoatId).ToList();
            return View(boats.Take(6));
        }
        public ViewResult WholeOffer()   /*string id*/
        {
            //int BoatId = id;
            //if(id != null && id > 0)
            //{
            //    var boats = objContext.Boats.Where(s => s.BoatID.Equals(id)).ToList();
            //}
            ////var boats = objContext.Boats.Where(s => s.BoatID.Equals(id)).ToList();
            //return View(boats);
            return View(objContext.Boats);
           
        }

        [HttpGet]
        public ActionResult TakeReservation()
        {
            return View(new Reservation());
        }
        [HttpPost]
       public ActionResult TakeReservation(int BoatID, DateTime DateFrom, DateTime DateTo, string NeedCaptain)
        {
            //objContext.Reservations.Add(reservation);
           objContext.SaveChanges();
            return RedirectToAction("TakeReservation");
        }

        [HttpGet]
        public ActionResult Kategorije(string category)
        {
            var boats = objContext.Boats.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

            return View(viewName: "WholeOffer", boats);
        }

        public ActionResult PublishYourBoat()
        {
            return View();
        }

    }
}


//, bool NeedCaptain

//int BoatID, DateTime DateFrom, DateTime DateTo