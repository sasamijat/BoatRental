using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.Models;
using System.ComponentModel.DataAnnotations;
using BoatsMontenegro.BaseBase;

namespace BoatsMontenegro.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Index()
        {
            using(BaseContext db = new BaseContext())
            {
                return View(db.Users.ToList());
            }
        }

        #region REGISTER 
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                using (BaseContext db = new BaseContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.Name + " " + user.Surname + " Uspesno registrovani.";
            }
            return View();
        }
        #endregion

        #region LOGIN
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            using (BaseContext db = new BaseContext())
            {
                var usr = db.Users.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Korisnicko ime ili lozinka su pogresni");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if(Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session["Username"] = string.Empty;
            Session["UserID"] = string.Empty;
            return RedirectToAction("Index", "Home");
        }

    }
}

/*
[HttpGet]
public ActionResult Login()
{
    return View();
}

[HttpPost]
public ActionResult Login(User model)
{
    if (ModelState.IsValid)
    {
        using(var context = new BaseContext())
        {
            User user = context.Users.Where(u => u.UserID == model.UserID && u.Password == model.Password).FirstOrDefault();
            if(user != null)
            {
                Session["Username"] = user.Username;
                Session["UserID"] = user.UserID;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Pogresno koriscnicko ime ili lozinka");
                return View(model);
            }
        }
    }
    else
    {
        return View(model);
    }
}

[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult LogOff()
{
    Session["Username"] = string.Empty;
    Session["UserID"] = string.Empty;
    return RedirectToAction("Index", "Home");
}
*/
