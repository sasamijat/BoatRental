using HotelWorkOrderManagement.Service.TaskStateChange;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
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
    }
}
