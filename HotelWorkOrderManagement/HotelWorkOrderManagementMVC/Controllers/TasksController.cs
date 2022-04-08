using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service.Task;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
    public class TasksController : Controller
    {
        private ITaskService _service;

        public TasksController(ITaskService service)
        {
            _service = service;
        }

        [BindProperty]
        public TaskDataIn TaskDataIn { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            List<TaskDataIn> tasks = _service.myTasks(2);
            ViewBag.Tasks = tasks;
            ViewBag.Team=null;
            return View();
        }

        [HttpGet]
        public IActionResult GetTask(int id)
        {
            TaskDataIn = _service.getTask(id);
            return View(TaskDataIn);
        }

        [HttpGet]
        public string GetTaskName(int id)
        {
            TaskDataIn task= _service.getTask(id);
            return task.Name;
        }



    }
}
