using HotelWorkOrderManagement.DTO.Group.DataIn;
using HotelWorkOrderManagement.DTO.Group.DataOut;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Service.Group;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HotelWorkOrderManagementMVC.Controllers
{
    [Authorize]
    public class GroupsController : Controller
    {
        private IGroupService _service;
        private IHttpContextAccessor _httpContextAccessor;


        public GroupsController(IGroupService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [BindProperty]
        public GroupDataIn GroupDataIn { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public string getGroupName(int id)
        {
            GroupDataIn group=_service.getGroup(1);
            return group.Name;
        }

        public IActionResult MyGroups()
        {
            int UserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            List<GroupDataOut> groups = _service.getMyGroups(UserId);
            ViewBag.UserId=UserId;
            ViewBag.Groups = groups;
            return View();
        }

        [HttpGet]
        public List<EmployeeDataOut> getAllEmployeesExceptGroupMembers(int id)
        {
            return _service.getAllEmployeesExceptGroupMembers(id);
        }

        [HttpPost]
        public void addMember(int id,int groupId)
        {
            _service.addMember(id,groupId);
        }

        [HttpPost]
        public void removeMember(int id, int groupId)
        {
            _service.removeMember(id, groupId);
        }
        
        [HttpPost]
        public void SelfTaskAssign(int id, bool signal)
        {
            _service.SelfTaskAssign(id, signal);
        }

    }
}
