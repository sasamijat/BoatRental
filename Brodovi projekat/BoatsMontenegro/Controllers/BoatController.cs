using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.BaseBase;
using BoatsMontenegro.Models;

namespace BoatsMontenegro.Controllers
{
    public class BoatController : Controller
    {
        BaseContext objContext;
        public BoatController()
        {
            objContext = new BaseContext();
        }



        // DETAILS Boat
        #region LIST and DETAILS - Boat
        public ActionResult Index()
        {
            var boats = objContext.Boats.ToList();
            return View(boats);
        }
        public ViewResult Details(int id)
        {
            Boat boat = objContext.Boats.Where(b => b.BoatID == id).SingleOrDefault();
            return View(boat);
        }
        #endregion



        // CREATE Boat
        #region CREATE Boat
        public ActionResult Create()
        {
            return View(new Boat());
        }
        [HttpPost]
        public ActionResult Create(Boat boat)
        {
            objContext.Boats.Add(boat);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion



        // EDIT Boat
        #region EDIT teacher
        public ActionResult Edit(int id)
        {
            Boat boat = objContext.Boats.Where
                (b => b.BoatID == id).SingleOrDefault();
            return View(boat);              
        }
        [HttpPost]
        public ActionResult Edit(Boat model)
        {
            Boat boat = objContext.Boats.Where(b => b.BoatID == model.BoatID).SingleOrDefault();
            if(boat != null)
            {
                objContext.Entry(boat).CurrentValues.SetValues(model);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        #endregion



        //BoatToUpdate.Capacity = 55;
        //    db.SaveChanges();


        // DELETE Boat
        #region DELETE
        public ActionResult Delete(int id)
        {
            Boat boat = objContext.Boats.Find(id);
            return View(boat);
        }
        [HttpPost]
        public ActionResult Delete(int id, Boat model)
        {
            var boat = objContext.Boats.Where(b => b.BoatID == id).SingleOrDefault();
            if(boat != null)
            {
                objContext.Boats.Remove(boat);
                objContext.SaveChanges();
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

//  private BaseContext db = new BaseContext();

// public BoatController(){}
//  public BoatController(BaseContext db)
//  {
//      this.db = db;
//  } 
// GET: Boat