using HotelWorkOrderManagement.DTO.Comment;
using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.Task.DataOut;
using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service.Task;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Security.Claims;

namespace HotelWorkOrderManagementMVC.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        private ITaskService _service;
        private IHttpContextAccessor _httpContextAccessor;
        IWebHostEnvironment _webHostEnvironment;

        public TasksController(ITaskService service, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment hostEnvironment)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public TaskDataOut TaskDataOut { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks(bool team,string? sortOrder)
        {
            int UserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            List<TaskDataOut> tasks = _service.myTasks(UserId,team);
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
            ViewBag.UserId = UserId;
            return View();
        }

        [HttpGet]
        public IActionResult GetTask(int id)
        {
            int UserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            ViewBag.UserId = UserId;
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
        public IActionResult addNewTask(bool? group)
        {
            int UserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            ViewBag.Group = group;
            ViewBag.CurrentUserId=UserId;
            TaskDataOut = _service.getNewTask(UserId);
            return View(TaskDataOut);
        }

        [HttpPost]
        public void addNewTask(TaskDataOut taskDO)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(taskDO.Attachment!=null)
                {
                    string[] file = taskDO.Attachment.Split(',');
                    taskDO.Picture = LoadImage(file[1], taskDO.ImageName);
                    uniqueFileName = UploadedFile(taskDO.Picture, "tasks");
                }
                

                taskDO.CreatedOn = DateTime.Now;
                _service.addNewTask(taskDO,uniqueFileName);
            }
        }

        public IFormFile LoadImage(string file,string imageName)
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(file);

            IFormFile commentImage;
            MemoryStream ms = new MemoryStream(bytes);
            
                commentImage = new FormFile(ms, 0, bytes.Length, "imageString", imageName);
            

            return commentImage;
        }


        [HttpPost]
        public void SubmitComment(CommentDataIn model)
        {
            string uniqueFileName=null;
            if(model.CommentImage != null)
            {
                string[] file = model.CommentImage.Split(',');
                model.CommentFile = LoadImage(file[1], model.ImageName);
                uniqueFileName = UploadedFile(model.CommentFile, null);
            }
            
            _service.SubmitComment(model,uniqueFileName);
        }
        
        [HttpPost]
        public void RemoveComment(int id)
        {
            _service.RemoveComment(id);
        }

        private string UploadedFile(IFormFile CommentImage,string? folder)
        {
            if (folder == null)
                folder = "comments";
            string uniqueFileName = null;

            if (CommentImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + CommentImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                var fileStream = new FileStream(filePath, FileMode.Create);
                
                CommentImage.CopyTo(fileStream);
                fileStream.Close();
                
            }
            return uniqueFileName;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAllTasks(bool? team,string? sortOrder)
        {
            List<TaskDataOut> tasks = _service.GetAllTasks(team);
            switch (sortOrder)
            {
                case null:
                    break;
                case "priority":
                    tasks = tasks.OrderBy(t => t.Priority).ToList();
                    break;
                case "priority_desc":
                    tasks = tasks.OrderByDescending(t => t.Priority).ToList();
                    break;
                case "status":
                    tasks = tasks.OrderBy(t => t.Status).ToList();
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
            ViewBag.Team = team;
            return View();
        }

        [HttpPost]
        public void TakeSelectedTask(int taskId,int userId)
        {
            _service.TakeSelectedTask(taskId, userId);
        }

        [HttpGet]
        public IActionResult GroupOrIndividual()
        {
            return View();
        }




    }
}

