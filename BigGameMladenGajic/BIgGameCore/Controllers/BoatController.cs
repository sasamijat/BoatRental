using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.DAO;
using BIgGameCore.Infrastructure;
using BIgGameCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.Controllers
{
    public class BoatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BoatsOfUser(int id)
        {

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            
            ViewBag.isMyProfile = isMyProfile(id);

            return View(BoatsDAO.getBoatsOfUser(id));
        }

        [HttpGet]
        public IActionResult AddNewBoat() {

            if (HttpContext.Session.GetObject<User>("CurrentUser") == null) {

                return RedirectToAction("login", "Home");
            }

            return View();
        }

        [HttpPost]
        public int AddNewBoat(Boat newBoat) {



            User owner = HttpContext.Session.GetObject<User>("CurrentUser");
            if (owner == null)
            {

                return -1;
            }

            return BoatsDAO.AddNewBoat(newBoat, owner);


        }

        [HttpGet]
        public IActionResult deleteBoat(int boatID, int ownerID) {

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            if (currentUser == null) {
                return RedirectToAction("BoatsOfUser", new { id = ownerID });
            }

            if (BoatsDAO.deleteBoat(boatID, ownerID, currentUser.UserID))
            {
                ViewBag.message = $"uspesno ste obrisali brod {boatID}";
            }
            else {
                ViewBag.message = $"Nismo uspeli da obrisemo brod {boatID}... :(";

            }

            ViewBag.isMyProfile = isMyProfile(ownerID);

            return View("BoatsOfUser", BoatsDAO.getBoatsOfUser(ownerID));
        }

        [HttpGet]
        public IActionResult editBoat(int boatID, int ownerID)
        {

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            if (currentUser == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(BoatsDAO.getBoat(boatID));
        }


        [HttpPost]
        public int EditBoat(Boat newBoat)
        {



            User owner = HttpContext.Session.GetObject<User>("CurrentUser");
            if (owner == null)
            {

                return -1;
            }

            return BoatsDAO.EditBoat(newBoat);


        }

        [HttpPost]
        public void DeleteImageForBoat(BoatImage img) {

            BoatsDAO.DeleteImageForBoat(img.BoatId, img.Image);

        }


        private bool isMyProfile(int id){

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            if (currentUser != null)
                return currentUser.UserID == id;
            else
                return false;
        }
    }
}
