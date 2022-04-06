using HotelWorkOrderManagement.DTO.Group.DataIn;
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
            GroupDataIn group=_service.getGroup(id);
            return group.Name;
        }

    }
}
