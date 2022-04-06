using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Equipment.DataIn
{
    public class EquipmentPieceDataIn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfInterventions { get; set; }
        public DateTime? InstalationDate { get; set; }
        public DateTime? LastIntervention { get; set; }
        public int? InstalatedById { get; set; }

        public EquipmentPieceDataIn() { }

        public EquipmentPieceDataIn(EquipmentPiece equipmentPiece)
        {
            Id = equipmentPiece.Id;
            Name = equipmentPiece.Name;
            NumOfInterventions = equipmentPiece.NumOfInterventions;
            InstalationDate = equipmentPiece.InstalationDate;
            LastIntervention = equipmentPiece.LastIntervention;
            InstalatedById = equipmentPiece.InstalatedById;
        }
    }
}
