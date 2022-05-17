using Microsoft.AspNetCore.Mvc;
using BIgGameCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.Models;
using BIgGameCore.DAO;

namespace BIgGameCore.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");

            if (currentUser == null) {
                return View("Login");
            }


            DateTime startDate = HttpContext.Session.GetObject<DateTime>("startDate");
            DateTime endDate = HttpContext.Session.GetObject<DateTime>("endDate");
            double totalHours = HttpContext.Session.GetObject<double>("totalHours");
            double totoalPrice = HttpContext.Session.GetObject<double>("totalPrice");
            BBA bba = HttpContext.Session.GetObject<BBA>("bbaForReservation");

            ViewBag.startDate = startDate;
            ViewBag.endDate = endDate;
            ViewBag.totalHours = totalHours;
            ViewBag.totalPrice = totoalPrice;
            ViewBag.bba = bba;
            ViewBag.currentUser = currentUser;

            return View();
        }

        public IActionResult Login([FromForm] string username, [FromForm] string password)
        {
            using (var context = new BigGameContext())
            {

                int userID = 0;
                foreach (User user in context.Users)
                {
                    if ((user.Email == username && user.Password == password) || (int.TryParse(username, out userID) && user.UserID == userID && user.Password == password))
                    {

                        HttpContext.Session.SetObject("CurrentUser", user);
                        ViewBag.CurrentUser = HttpContext.Session.GetObject<User>("CurrentUser");

                        return RedirectToAction("Index", "Reservation");
                    }

                }
                ViewBag.LoginMessage = "Neispravni kredencijali!";
            }

            return View();
        }

        public IActionResult Registration() {
            return View();
        }
        public IActionResult Register([FromQuery] string FirstName,
                                   [FromQuery] string LastName,
                                   [FromQuery] string Phone,
                                   [FromQuery] string Email,
                                   [FromQuery] string Password,
                                   [FromQuery] string PasswordCheck)
        {
            if (Password == PasswordCheck)
            {

                using (var context = new BigGameContext())
                {

                    User newUser = new User { FirstName = FirstName, LastName = LastName, Phone = Phone, Email = Email, Password = Password, Boats = null, Reservations = null };
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    ViewBag.SuccessRegistrationMessage = $"Uspesno ste se registrovali! Vas ID je : {newUser.UserID}";

                    return View("../Reservation/Login");
                }
            }
            else
            {
                ViewBag.Message = "Niste lepo uneli sifru molimo vas pokusajte ponovo!";
            }

            return View("../Reservation/Registration");
        }
        public IActionResult Reserve() {

            User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
            DateTime startDate = HttpContext.Session.GetObject<DateTime>("startDate");
            DateTime endDate = HttpContext.Session.GetObject<DateTime>("endDate");
            double totalHours = HttpContext.Session.GetObject<double>("totalHours");
            double totoalPrice = HttpContext.Session.GetObject<double>("totalPrice");
            BBA bba = HttpContext.Session.GetObject<BBA>("bbaForReservation");

            if (ReservationDAO.tryReserve(currentUser, startDate, endDate, bba))
            {
                return RedirectToAction("ReservationsOfUser",new { id = currentUser.UserID });
            }
            else
                ViewBag.poruka = ":( nismo uspeli da rezervisemo";


            return View();
        }
        public IActionResult ReservationsOfUser(int id)
        {

            User user = UsersDAO.getUserWithCompleteReservationsObject(id);

            if (user != null)
            {
                return View(user);
            }
            return View();

        }
        public IActionResult Details(int id) {

            return View(ReservationDAO.getReservationById(id));
        }

        public IActionResult Cancel(int id) {

            ReservationDAO.cancelReservation(id);
            return RedirectToAction("ReservationsOfUser", new { id =
            ReservationDAO.getReservationById(id).UserID
            });
        }
    }
}
