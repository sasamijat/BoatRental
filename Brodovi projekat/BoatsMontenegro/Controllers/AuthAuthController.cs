using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.AuthenticationAndAuthorization;
using BoatsMontenegro.Models;

namespace BoatsMontenegro.Controllers
{
    public class AuthAuthController : Controller
    {
        IAuthProvider authProvider;
        public AuthAuthController()
        {

        }
        public AuthAuthController(IAuthProvider auth)
        {
            authProvider = auth;
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {
             
            if (ModelState.IsValid)
            {
                if(authProvider.Authenticate(model.Username, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                else
                {
                    ModelState.AddModelError("", "Pogresno korisnicko ime ili lozinka");
                    return View();
                }                
            }           
            else
            {
                return View();
            }

            
            
        }
    }
}