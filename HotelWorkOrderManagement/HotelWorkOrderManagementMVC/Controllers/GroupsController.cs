using HotelWorkOrderManagement.DTO.Group.DataIn;
using HotelWorkOrderManagement.DTO.Group.DataOut;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Service.Group;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
    public class GroupsController : Controller
    {
        private IGroupService _service;

        public GroupsController(IGroupService service)
        {
            _service = service;
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

        public IActionResult MyGroups(int id)
        {
            List<GroupDataOut> groups = _service.getMyGroups(3);
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

    }
}
