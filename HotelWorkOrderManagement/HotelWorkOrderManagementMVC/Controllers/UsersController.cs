using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;


namespace HotelWorkOrderManagementMVC.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private IUserService _service;
        private IHttpContextAccessor _httpContextAccessor;
        IWebHostEnvironment _webHostEnvironment;

        public UsersController(IUserService service,IHttpContextAccessor httpContextAccessor,IWebHostEnvironment hostEnvironment)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public UserDataIn UserDataIn { get; set; }



        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            UserDataIn = new UserDataIn();
            if (id == null)
            {
            //create
            return View(UserDataIn);
            }
            //update
            UserDataIn = _service.getUser(id.Value);
            if (UserDataIn == null)
            {
                return NotFound();
            }
            return View(UserDataIn);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {                
                string uniqueFileName = UploadedFile(UserDataIn);
                User user = new User(UserDataIn);
                user.ProfileImage = uniqueFileName;

                if (UserDataIn.Id == null || UserDataIn.Id==0)
                {                    
                    //create
                    _service.insertUser(user);
                }
                else
                {
                    _service.updateUser(user);
                }
                return RedirectToAction("Index");
            }
            return View(UserDataIn);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<UserDataIn> users = _service.getAllUsers();
            ViewBag.Users = users;
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {

            var user =await _service.removeUserAsync(id);
            if (user == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            return Json(new { success = true, message = "Delete successful" });
            
        }

        [HttpGet]
        public string GetUserName(int id)
        {
            UserDataIn user = _service.getUser(id);
            return user.UserName;
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            int UserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            UserDataIn user= _service.getUser(UserId);
            return View(user);
        }

        private string UploadedFile(UserDataIn model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public ActionResult IsUsernameAvailble(string Username)
        {
            bool signal=_service.IsUsernameAvailble(Username);
            return new JsonResult(signal, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

    }
}
