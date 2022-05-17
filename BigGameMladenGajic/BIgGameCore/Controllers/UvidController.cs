using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.DAO;
using Microsoft.AspNetCore.Mvc;
using BIgGameCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIgGameCore.Models;

namespace BIgGameCore.Controllers
{
    public class UvidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult BoatAvailability(int id ) {

            BBA bba = BoatsDAO.GetBoatAvailability(id);

            DateTime startDate = HttpContext.Session.GetObject<DateTime>("startDate");
            DateTime endDate = HttpContext.Session.GetObject<DateTime>("endDate");
            double totalHours = getTotalHours(startDate, endDate);
            double totalPrice = getTotalPrice(totalHours, bba.BoatAvailability.Price);

            if (endDate.Subtract(startDate) == TimeSpan.Zero)
            {

                ViewBag.NotForReservation = true;
                HttpContext.Session.Remove("startDate");
                HttpContext.Session.Remove("endDate");
                HttpContext.Session.Remove("totalHours");
                HttpContext.Session.Remove("totalPrice");

            }
            else {

                ViewBag.NotForReservation = false;
                HttpContext.Session.SetObject("startDate", startDate);
                HttpContext.Session.SetObject("endDate", endDate);
                HttpContext.Session.SetObject("bbaForReservation", bba);
                HttpContext.Session.SetObject("totalHours", totalHours);
                HttpContext.Session.SetObject("totalPrice", totalPrice);

            }



            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;
            ViewBag.TotalHours = totalHours;
            ViewBag.TotalPrice = totalPrice;

            return View(bba);
        }


        public IActionResult boat(int id) {

            Boat boat = BoatsDAO.getBoat(id);

            return View(boat);
        }


        public IActionResult Boats()
        {

            return View(BoatsDAO.getAllBoats());
        }

        public IActionResult BoatsFilter([FromQuery] int passangersCapacity,[FromQuery] int year,[FromQuery] int lenght)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters.Add("Broj putnika", passangersCapacity.ToString());
            if (year != 0)
            {
                filters.Add("Godina proizvodnje", year.ToString());
            }
            if (lenght > 10)
            {
                filters.Add("Dužina broda (min)", lenght.ToString());
            }
            ViewBag.filters = filters;

            return View("boats",BoatsDAO.getBoatsFilter(passangersCapacity,year,lenght));
        }

        private double getTotalHours(DateTime startDate, DateTime endDate) {

            return (endDate - startDate).TotalHours;

        }

        private double getTotalPrice(double hours, double price) {
            return hours * price;
        }


    }
}
