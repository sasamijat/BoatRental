using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.Task.DataOut;
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
        public TaskDataOut TaskDataOut { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks(int id,bool team,string? sortOrder)
        {
            List<TaskDataOut> tasks = _service.myTasks(id,team);
            switch (sortOrder)
            {
                case null:
                    break;
                case "priority":
                    tasks=tasks.OrderBy(t => t.Priority).ToList();
                    break;
                case "priority_desc":
                    tasks=tasks.OrderByDescending(t => t.Priority).ToList();
                    break;
                case "status":
                    tasks=tasks.OrderBy(t => t.Status).ToList();
                    break;
                case "status_desc":
                    tasks = tasks.OrderByDescending(t => t.Status).ToList();
                    break;
                case "due_date":
                    tasks = tasks.OrderBy(t => t.DueDate).ToList();
                    break;
                case "due_date_desc":
                    tasks = tasks.OrderByDescending(t => t.DueDate).ToList();
                    break;
                    default:
                    break;
                
            }
            ViewBag.SortOrder = sortOrder;
            ViewBag.Tasks = tasks;
            ViewBag.Team=team;
            ViewBag.Id = id;
            ViewBag.Team = team;
            return View();
        }

        [HttpGet]
        public IActionResult GetTask(int id)
        {
            TaskDataOut TaskDataOut = _service.getTask(id);
            return View(TaskDataOut);
        }

        [HttpGet]
        public string GetTaskName(int id)
        {
            TaskDataOut task= _service.getTask(id);
            return task.Name;
        }

        [HttpPost]
        public void repetitiveSetting(int id, string repSetting, DateTime repStart)
        {
            _service.repetitiveSetting(id, repSetting, repStart);
        }

        [HttpPost]
        public void repetitiveRemove(int id)
        {
            _service.repetitiveRemove(id);
        }

        [HttpGet]
        public IActionResult addNewTask()
        {
            TaskDataOut = _service.getNewTask();
            return View(TaskDataOut);
        }

        [HttpPost]
        public void addNewTask(TaskDataOut taskDO)
        {
            HotelWorkOrderManagement.Models.Task task = new HotelWorkOrderManagement.Models.Task(taskDO);
            if(ModelState.IsValid)
            {
                task.CreatedOn = DateTime.Now;
                _service.addNewTask(task);
            }
        }

        


    }
}

