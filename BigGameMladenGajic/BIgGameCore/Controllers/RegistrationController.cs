using BigGame.Models;
using BigGame.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index([FromQuery] string FirstName ,
                                    [FromQuery] string LastName ,
                                    [FromQuery] string Phone,
                                    [FromQuery] string Email,
                                    [FromQuery] string Password,
                                    [FromQuery] string PasswordCheck)
        {
            if (Password == PasswordCheck && FirstName != null && FirstName.Length > 2 
                && LastName != null && LastName.Length > 2 
                && Phone != null && Phone.Length > 5 
                && Email != null && Email.Length > 5
                && Password != null && Password.Length > 5) {

                using (var context = new BigGameContext()) {

                    User newUser = new User { FirstName = FirstName, LastName = LastName, Phone = Phone, Email = Email, Password = Password, Boats = null, Reservations = null };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    
                    ViewBag.SuccessRegistrationMessage = $"Uspesno ste se registrovali! Vas ID je : {newUser.UserID}";

                    return View("../Home/Login");
                }
            }
            else
            {
                ViewBag.Message = "Niste lepo popunili formu! Sva polja moraju biti validno popunjana, i lozinka mora imati vise od 5 karaktera! ";
            }

            return View("../Home/Registration");
        }
    }
}
