using Microsoft.AspNetCore.Mvc;
using HotelWorkOrderManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.Task.DataOut;

namespace HotelWorkOrderManagementMVC.Controllers
{
    public class TasksController : Controller
    {
            private readonly ApplicationDbContext _db;
            [BindProperty]
            public TaskDataIn TaskDataIn { get; set; }
            public TaskDataOut TaskDataOut { get; set; }
        public TasksController(ApplicationDbContext db)
            {
                _db = db;
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Upsert(int? id)
            {
            TaskDataIn = new TaskDataIn();
                //if (id == null)
                //{
                    //create
                    return View(TaskDataIn);
                //}
            ////update
            // TaskDataOut = new TaskDataOut(_db.Tasks.FirstOrDefault(u => u.Id == id));
            //TaskDataIn=(TaskDataIn)TaskDataOut;
            //    if (TaskDataOut == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(Task);
            }

            [HttpPost]
            public IActionResult Upsert()
            {

            if (ModelState.IsValid)
                {
                    if (TaskDataIn.Id == 0)
                    {
                        //create
                        _db.Tasks.Add(new HotelWorkOrderManagement.Models.Task(TaskDataIn));
                    }
                    else
                    {
                        _db.Tasks.Update(new HotelWorkOrderManagement.Models.Task(TaskDataIn));
                    }
                    _db.SaveChanges();
                    return RedirectToAction("Home/Index");
                }
                return View(TaskDataIn);
            }

            #region API Calls
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                return Json(new { data = await _db.Tasks.ToListAsync() });
            }

            [HttpDelete]
            public async Task<IActionResult> Delete(int id)
            {
                var taskFromDb = await _db.Tasks.FirstOrDefaultAsync(u => u.Id == id);
                if (taskFromDb == null)
                {
                    return Json(new { success = false, message = "Error while Deleting" });
                }
                _db.Tasks.Remove(taskFromDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete successful" });
            }
            #endregion
        }
    
}
