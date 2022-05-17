using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.DAO;
using BIgGameCore.Infrastructure;
using BIgGameCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var context = new BigGameContext()) {
            

                return View(context.Users.ToList());
            }

        }

        public IActionResult Registration() {


            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult DeleteUser(int id) {


            if (UsersDAO.RemoveUser(id))
            {
                ViewBag.Message = $"Uspesno ste ukolnili korisnika #{id}";
            }

            return View("Index");
            
        }

        public IActionResult Profile(int id) {

            User user = UsersDAO.getUserWithReservationsAndBoats(id);
            if (user != null)
            {
                User currentUser = HttpContext.Session.GetObject<User>("CurrentUser");
                if (currentUser != null)
                    ViewBag.isMyProfile = currentUser.UserID == id;
                else
                    ViewBag.isMyProfile = false;

                ViewBag.ActiveBoatAvailabilities = BoatsDAO.getActiveBBAOfUser(user.UserID);
                return View(user);
            }
            return View("Index");
        
        }

        public IActionResult AvailableBoats() {
            return View(null);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
