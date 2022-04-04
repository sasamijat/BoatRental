using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [BindProperty]
        public UserDataIn UserDataIn { get; set; }


        public IActionResult Index()
        {
            return View();
        }

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
        [HttpPost]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (UserDataIn.Id == 0)
                {
                    //create
                    _service.insertUser(UserDataIn);
                }
                else
                {
                    _service.updateUser(UserDataIn);
                }
                return RedirectToAction("Index");
            }
            return View(UserDataIn);
        }

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
    }
}
