using HotelWorkOrderManagement.DTO.Equipment.DataIn;
using HotelWorkOrderManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.EquipmentPiece
{
    public class EquipmentPieceService : IEquipmentPieceService
    {
        private readonly ApplicationDbContext context;
        public EquipmentPieceService(ApplicationDbContext db)
        {
            context = db;
        }
        public List<Models.EquipmentPiece> GetAllEquipmentPieces() {

            using (context)
            {
                return context.EquipmentPieces.Include(x=>x.InstalatedBy).ToList();
            }
        
        }

        public EquipmentPieceDataIn getEquipmentPiece(int id) {

            EquipmentPieceDataIn equipment;
            using (context)
            {
                equipment = new EquipmentPieceDataIn(context.EquipmentPieces.FirstOrDefault(e => e.Id == id));
            }
            return equipment;
        }
    }
}
