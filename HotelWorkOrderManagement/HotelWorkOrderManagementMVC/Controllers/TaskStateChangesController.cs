using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.TaskStateChange.DataIn;
using HotelWorkOrderManagement.Service.TaskStateChange;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
    [Authorize]
    public class TaskStateChangesController : Controller
    {
        ITaskStateChangeService _service;
        public TaskStateChangesController(ITaskStateChangeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetTaskStateChanges(int Id)
        {
            ViewBag.TaskStateChanges=_service.getTaskStateChange(Id);
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void SetNewStatus(int taskId,int executorId,string status,string description)
        {
            TaskStateChangeDataIn taskStateChange = new TaskStateChangeDataIn()
            {
                TaskId = taskId,
                ExecutorId = executorId,
                Status = status,
                Description = description,
                DateOfChange = DateTime.Now,
            };
            _service.updateTaskStatus(taskStateChange, taskId, status);
            
            
        }

        [HttpPost]
        public void DropTask(int taskId, int executorId,string description)
        {
            TaskStateChangeDataIn taskStateChange = new TaskStateChangeDataIn()
            {
                TaskId = taskId,
                ExecutorId = executorId,
                Status="Dropped",
                Description = description,
                DateOfChange = DateTime.Now,
            };
            _service.dropTask(taskStateChange, taskId);
        }
    }
}
