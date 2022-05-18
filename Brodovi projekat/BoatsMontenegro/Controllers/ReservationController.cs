using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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
           //Reservation reservation = objContext.Reservations.Where(r => r.ReservationID == id).SingleOrDefault();
            return View("TakeReservation", new ReservationContract());
        }
        [HttpPost]
        public ActionResult Create(ReservationContract newResevation)
        {

            //objContext.Reservations.Add(reservation);
            //objContext.SaveChanges();           

            return RedirectToAction("Index");
        }
        #endregion


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
       
        #region EDIT 
        public ActionResult Edit(int id)
        {
            Reservation reservation = objContext.Reservations.Where(r => r.ReservationID == id).SingleOrDefault();
            return View(reservation);
        }      
        [HttpPost]
        public ActionResult Edit(int ReservationID, string tripstart, string tripend, bool NeedCaptain)
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
