using BIgGameCore.DAO;
using Microsoft.AspNetCore.Mvc;
using BIgGameCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIgGameCore.Models;
using BigGame.Models;

namespace BIgGameCore.Controllers
{
    public class BoatAvailabilityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AvialabilityResult([FromForm] DateTime startDate, [FromForm] DateTime endDate) {

            if (startDate < DateTime.Now.AddDays(-1) || endDate < DateTime.Now || endDate < startDate)
                return View("../Home/AvailableBoats",null);

            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;


            HttpContext.Session.SetObject("startDate", startDate);
            HttpContext.Session.SetObject("endDate", endDate);

            return View("../Home/AvailableBoats", BoatsDAO.availabilityBoats(startDate,endDate));
        }
        public IActionResult AvialabilityResultForBoat(int id, [FromForm] DateTime startDate, [FromForm] DateTime endDate)
        {



            if (startDate < DateTime.Now.AddDays(-1) || endDate < DateTime.Now || endDate < startDate) 
                return View("../Uvid/boat", BoatsDAO.getBoat(id));

            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;


            HttpContext.Session.SetObject("startDate", startDate);
            HttpContext.Session.SetObject("endDate", endDate);

            BBA availableBoat = BoatsDAO.isBoatAvailable(id, startDate, endDate);
            if (availableBoat != null)
            {
                double totalHours = (endDate - startDate).TotalHours;
                double totalPrice = totalHours * availableBoat.BoatAvailability.Price;
                
                HttpContext.Session.SetObject("bbaForReservation", availableBoat);
                HttpContext.Session.SetObject("totalHours", totalHours);
                HttpContext.Session.SetObject("totalPrice", totalPrice);


                ViewBag.totalHours = totalHours;
                ViewBag.totalPrice = totalPrice;

                return View("../Uvid/BoatAvailability", availableBoat);
            }
            else
            {
                ViewBag.NotAvailableBoatAtTermins = true;
                return View("../Uvid/boat", BoatsDAO.getBoat(id));
            }
        }


        [HttpGet]
        public IActionResult AddNewBoatAvailability(int id)
        {
            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");

            if ( currentUser == null)
            {

                return RedirectToAction("login", "Home");
            }
            ViewBag.boatID = id;
            if(id != 0)
                ViewBag.boat = BoatsDAO.getBoat(id);
            return View(UsersDAO.getUserWithBoats(currentUser.UserID));
        }

        [HttpPost]
        public IActionResult AddNewBoatAvailability([FromForm] int boatId,[FromForm] DateTime startDate, [FromForm] DateTime endDate , [FromForm] float price,[FromForm] string location)
        {
            

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            if (currentUser == null)
            {

                return RedirectToAction("login", "Home");
            }
            if (boatId == 0) {
                ViewBag.message = "Morate odabrati brod!";
                return View(UsersDAO.getUserWithBoats(currentUser.UserID));
            }
            BoatAvailability newOne = new BoatAvailability() { BoatID = boatId, StartDate = startDate, EndDate = endDate, Price = price, Location = location };
            if (BoatAvailabilityDAO.addNewBoatAvailability(newOne)) {
                return RedirectToAction("profile", "home", new { id = currentUser.UserID });
            }

            return View(UsersDAO.getUserWithBoats(currentUser.UserID));
        }

        public IActionResult deleteBoatAvailability(int id) {
            
            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            if (currentUser == null)
            {

                return RedirectToAction("login", "Home");
            }

            BoatAvailabilityDAO.deleteBoatAvailability(id);

            return RedirectToAction("profile","home",new { id = currentUser.UserID});
        }
    }
}
