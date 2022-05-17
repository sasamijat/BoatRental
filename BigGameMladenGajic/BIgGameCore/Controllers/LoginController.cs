using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.DAO;
using BIgGameCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index([FromForm] string username,[FromForm] string password)
        {
            User user = UsersDAO.tryLogin(username,password);
            
            if (user != null)
            {
                HttpContext.Session.SetObject("CurrentUser", user);
                ViewBag.CurrentUser = HttpContext.Session.GetObject<User>("CurrentUser");

                return RedirectToAction("Profile", "Home", new { id = user.UserID });
            }
            else
            {

                ViewBag.LoginMessage = "Neispravni kredencijali!";
            }

            return View("../Home/Login");
        }

        public IActionResult LogOut() {

            HttpContext.Session.Remove("CurrentUser");

            return View("../Home/Login");
        }
    
    }

    
}
