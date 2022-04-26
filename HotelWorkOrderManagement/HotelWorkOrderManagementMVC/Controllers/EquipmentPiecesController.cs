using HotelWorkOrderManagement.DTO.Equipment.DataIn;
using HotelWorkOrderManagement.Service.EquipmentPiece;
using Microsoft.AspNetCore.Mvc;

namespace HotelWorkOrderManagementMVC.Controllers
{
    public class EquipmentPiecesController : Controller
    {
        private IEquipmentPieceService _service;

        public EquipmentPiecesController(IEquipmentPieceService service)
        {
            _service = service;
        }

        [BindProperty]
        public EquipmentPieceDataIn GroupDataIn { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public string getGroupName(int id)
        {
            EquipmentPieceDataIn group = _service.getEquipmentPiece(id);
            return group.Name;
        }
    }
}
