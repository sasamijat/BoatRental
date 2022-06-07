using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.AutorizationAuthentication;
using BoatsMontenegro.BaseBase;
using BoatsMontenegro.Contracts;
using BoatsMontenegro.Models;

namespace BoatsMontenegro.Controllers
{
   
    public class ReservationController : Controller
    {      
        BaseContext objContext;
        public ReservationController()
        {
            objContext = new BaseContext();
        }

        #region LIST and DETAILS Reservation
        public ActionResult Index()
        {
            var reservations = objContext.Reservations.ToList();
            return View(reservations);
        }
        public ActionResult Details(int id)
        {
            Reservation reservation = objContext.Reservations.Where(r => r.ReservationID == id).SingleOrDefault();
            return View(reservation);
        }
        #endregion

        #region CREATE
        public ActionResult Create()
        {
            var existingBoats = objContext.Boats;
            ViewData["boats"] = existingBoats;
            return View(new ReservationContract());
        }

        [HttpPost]
        public ActionResult Create(DateTime dateFrom, DateTime dateTo, string needCaptain, int id)
        {
            
            if (ModelState.IsValid) 
            {
                Reservation reservation = new Reservation()
                {
                    Boat = objContext.Boats.First(x => x.BoatID == id)
                };
                reservation.DateFrom = dateFrom;
                reservation.DateTo = dateTo;
                reservation.NeedCaptain = needCaptain;
                reservation.Boat.BoatID = id;
                objContext.Reservations.Add(reservation);
                objContext.SaveChanges();
                
            }
            return RedirectToAction("Index", "Reservation");
                     
            //return View("Index");
            
        }
        #endregion

        #region EDIT 
        public ActionResult Edit(int id)
        {
            Reservation reservation = objContext.Reservations.Where(r => r.ReservationID == id).SingleOrDefault();
            return View(reservation);
        }      
        [HttpPost]
        public ActionResult Edit(int ReservationID, string tripstart, string tripend, string NeedCaptain)
        {           
            Reservation reservation = objContext.Reservations.Where(r => r.ReservationID == ReservationID).SingleOrDefault();
                if(reservation != null)
            {
                reservation.NeedCaptain = NeedCaptain;
                reservation.DateFrom = Convert.ToDateTime(tripstart);
                reservation.DateTo = Convert.ToDateTime(tripend);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }           
            return View(reservation);
        }
        #endregion      

        #region DELETE
        public ActionResult Delete(int id)
        {
            Reservation reservation = objContext.Reservations.Find(id);
            return View(reservation);
        }
        [HttpPost]      
        public ActionResult Delete(int id, Reservation model)
        {
            var reservation = objContext.Reservations.Where(r => r.ReservationID == id).SingleOrDefault();
            if(reservation != null)
            {
                objContext.Reservations.Remove(reservation);
                objContext.SaveChanges();
                //   objContext.Entry(reservation).CurrentValues.SetValues(model);               
                //  return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        #endregion

        //[CustomAuthorize("Admin", "Buyer", "Seller")]
        public ActionResult ScheduledAppointment(int? idboat)
        {
            //var reservations1 = new Reservation();
            //var reservations1 = new List<Reservation>();
            var Boatid1 = idboat;
            //int boatid1 = Int32.Parse(idboat);
            var reservations1 = objContext.Reservations.Where(r => r.Boat.BoatID == Boatid1).ToList();

            //var reservations1 = objContext.Reservations.Where(r => r.Boat.BoatID == idboat).ToList();
        
            return View(reservations1);


            //if (idboat != null)
            //{
            //    var reservations1 = objContext.Reservations.Where(r => r.Boat.BoatID == idboat).ToList();
            //    //return View(viewName: "ScheduledAppointments");
            //    return RedirectToAction("ScheduledAppointments", "Reservation");
            //}
            //else
            //{
            //    //return View("Index");
            //    //return View("WholeOffer");
            //    return RedirectToAction("Create","Reservation");
            //}
        }

        //public ActionResult ReservedAppointments()
        //{

        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                objContext.Dispose();
            }
            base.Dispose(disposing);
        }     
    }
}







//[HttpGet]
//public ActionResult TakeReservation()
//{
//    return View(new Reservation());
//}
//[HttpPost]
//public ActionResult TakeReservation(int BoatID, DateTime DateFrom, DateTime DateTo, string NeedCaptain)
//{
//    //objContext.Reservations.Add(reservation);
//    objContext.SaveChanges();
//    return RedirectToAction("TakeReservation");
//}


/*
       try { 
           ViewData["DateFrom"] = dateFrom;
           ViewData["DateTo"] = dateTo;
           ViewData["NeedCaptain"] = needCaptain;
           ViewData["BoatID"] = id;
           return View("Index");
           }
           catch { return View(); }
       */

//objContext.Reservations.Add(reservation);
//int boatid = Request["BoatID"];
//objContext.SaveChanges();
//return RedirectToAction("Index");
/*

/*
[HttpPost]
public ActionResult Create(ReservationContract newResevation)
{
    ////Validiraj da li je korisnik ulogovan. Proveriti da userId i Username iz sesije nisu null/empty.////
    ////Validiraj da li brod postoji////
    ////Proveriti da li je dateFrom pre dateTo////
    ////Proveriti da li je korisnik koji rezervise slobodan u terminu dateFrom - dateTo////
    ////Proveriti da li je brod koji rezervise slobodan u terminu dateFrom - dateTo////

    var reservation = new Reservation()
    {
        NeedCaptain = newResevation.NeedCaptain,
        DateFrom = newResevation.DateFrom,
        DateTo = newResevation.DateTo,
        Boat = objContext.Boats.Find(newResevation.BoatID),
        ReservedBy = objContext.Users.Find(int.Parse(Session["UserID"].ToString()))
    };
    objContext.Reservations.Add(reservation);
    objContext.SaveChanges();
    //objContext.Reservations.Add(reservation);
    //objContext.SaveChanges();           

    return RedirectToAction("Index");
}
*/