using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.Models;
using System.ComponentModel.DataAnnotations;
using BoatsMontenegro.BaseBase;
using System.Web.Security;

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

        #region -----------------LOGIN--------------------
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User userLogin)
        {

            using(BaseContext dbCon = new BaseContext())
            {
                var usr = dbCon.Users.Single(u => u.Username == userLogin.Username && u.Password == userLogin.Password);
                if(usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Korisnicko ime ili lozinka nisu tacni.");
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
        

        #region ---------------REGISTER------------------
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User userRegister)
        {
            if (ModelState.IsValid)
            {
                using (BaseContext db = new BaseContext())
                {
                    db.Users.Add(userRegister);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = userRegister.FirstName + " " + userRegister.LastName + " Uspesno registrovani.";
            }
            return View();
        }
        #endregion

        public ActionResult LogOut()
        {
            //FormsAuthentication.SignOut();
            int UserID = (int)Session["UserID"];
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}



#region ACTIVATION ACCOUNT
/*
[HttpGet]
public ActionResult ActivationAccount(string id)
{
    bool statusAccount = false;
    using (BaseContext dbContext = new BaseContext())
    {
        var userAccount = dbContext.Users.Where(u => u.ActivationCode.ToString().Equals(id)).FirstOrDefault();
        if (userAccount != null)
        {
            userAccount.IsActive = true;
            dbContext.SaveChanges();
            statusAccount = true;
        }
        else
        {
            ViewBag.Message = "Something Wrong !!";
        }
    }
    ViewBag.Status = statusAccount;
    return View();
}
*/
#endregion

#region REGISTRATION REZERVA 
/*
 [HttpGet]       
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [CustomAuthorize(Roles="Buyer")]
        public ActionResult Registration(User userOb)
        {
            bool statusRegistration = false;
            string messageRegistration = string.Empty;
            if (ModelState.IsValid)
            {

                string userName = Membership.GetUserNameByEmail(userOb.Email);
                if (!string.IsNullOrEmpty(userName))
                {
                    ModelState.AddModelError("Warning Email", "Sorry: Email already Exists");
                    return View(userOb);
                }
                //Save User Data 
                using (AuthenticationDB dbContext = new AuthenticationDB())
                {
                    var user = new User()
                    {
                        Username = userOb.Username,
                        FirstName = userOb.FirstName,
                        LastName = userOb.LastName,
                        Email = userOb.Email,
                        Password = userOb.Password,
                       // ActivationCode = Guid.NewGuid(),
                    };
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
               // VerificationEmail(userOb.Email, userOb.ActivationCode.ToString());
                messageRegistration = "Your account has been created successfully. ^_^";
                statusRegistration = true;
            }
            else
            {
                messageRegistration = "Something Wrong!";
            }
            ViewBag.Message = messageRegistration;
            ViewBag.Status = statusRegistration;
            return View(userOb);
        }

*/
#endregion

#region LOGOUT REZERVA
/*
public ActionResult LogOut()
{
    HttpCookie cookie = new HttpCookie("Cookie1", "");
    cookie.Expires = DateTime.Now.AddYears(-1);
    Response.Cookies.Add(cookie);
    FormsAuthentication.SignOut();
    return RedirectToAction("Index", "Home", null);
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
#endregion LOGOUT REZERVA

#region LOGIN REZERVA 1
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
#endregion

#region LOGIN REZERVA 2
/*
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
        */
#endregion

#region LOGIN REZERVA 3
/*
       [HttpPost]
       public ActionResult Login(User userObj, string ReturnUrl = "")
       {
           if (ModelState.IsValid)
           {
               if (new CustomMembership().ValidateUser(userObj.Username, userObj.Password))
               {
                   FormsAuthentication.SetAuthCookie(userObj.Username, userObj.Password);
                   if (!String.IsNullOrEmpty(returnUrl))
                   {
                       return Redirect(returnUrl);
                   }
                   else
                   {
                       return RedirectToAction("Index", "Home");
                   }
               }

           }
       }
       */
#endregion

#region LOGIN REZERVA 4
/*
        [HttpPost]      
        public ActionResult Login(User userObj, string ReturnUrl = "")
        {
            if (ModelState.IsValid)
            {
                bool memberValid = Membership.ValidateUser(userObj.Username, userObj.Password);
                if (memberValid)
                {
                    var user = (CustomMembershipUser)Membership.GetUser(userObj.Username);
                    if (user != null)
                    {
                        User userModel = new Models.User()
                        {
                            UserId = user.UserId,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            //ne moze lista stringova u jedan string
                           //RoleName = user.RoleName
                           Role = user.RoleName
                        };
                       string userData = JsonConvert.SerializeObject(userModel);
                        FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket
                            (
                            1, userObj.Username, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData
                            );
                        string enTicket = FormsAuthentication.Encrypt(authTicket);
                        HttpCookie faCookie = new HttpCookie("Cookie1", enTicket);
                        Response.Cookies.Add(faCookie);
                    }
                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Pogresno korisnicko ime ili lozinka ");
            return View(userObj);
        }
        
        */
#endregion

#region LOGIN IZ MEMBERSHIPA
/*
[HttpGet]
public ActionResult Login(string ReturnUrl = "")
{
    if (User.Identity.IsAuthenticated)
    {
        return LogOff();
    }
    ViewBag.ReturnUrl = ReturnUrl;
    return View();
}
[HttpPost]
public ActionResult Login(User userObj, string ReturnUrl = "")
{
    if (ModelState.IsValid)
    {
        var isValidUser = Membership.ValidateUser(userObj.Username, userObj.Password);
        if (isValidUser)
        {
            FormsAuthentication.SetAuthCookie(userObj.Username, userObj.RememberMe);
            if (Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
    ModelState.Remove("Password");
    return View();
}
*/
#endregion