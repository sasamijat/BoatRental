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
using BoatsMontenegro.Models;

namespace BoatsMontenegro.Controllers
{
   
    public class UserController : Controller
    {
       
       BaseContext objContext;
       public UserController()
       {
            objContext = new BaseContext();
       }

        #region LIST and DETAILS
        public ActionResult Index()
        {
            var users = objContext.Users.ToList();
            return View(users);
        }
        public ActionResult Details(int? id)
        {
            User user = objContext.Users.Where(u => u.UserID == id).SingleOrDefault();
            return View(user);
        }
        #endregion



        // CREATE 
        #region CREATE
        public ActionResult Create()
        {
            return View(new User());
        }     
        [HttpPost]
        public ActionResult Create(User user)
        {
            objContext.Users.Add(user);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion



        // EDIT
        #region EDIT
        public ActionResult Edit(int id)
        {
            User user = objContext.Users.Where(u => u.UserID == id).SingleOrDefault();
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            User user = objContext.Users.Where(u => u.UserID == model.UserID).SingleOrDefault();
            if (user != null)
            {
                objContext.Entry(user).CurrentValues.SetValues(model);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        #endregion



        // DELETE
        #region DELETE
        [CustomAuthorize("Admin", "Buyer", "Seller")]
        public ActionResult Delete(int id)
        {
            User user = objContext.Users.Find(id);
            return View(user);
        }      
        [HttpPost]
        public ActionResult Delete(int id, User model)
        {
            var user = objContext.Users.Where(u => u.UserID == id).SingleOrDefault();
            if(user != null)
            {
                objContext.Users.Remove(user);
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
