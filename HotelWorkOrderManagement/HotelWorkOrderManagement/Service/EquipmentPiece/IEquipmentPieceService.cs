﻿using HotelWorkOrderManagement.DTO.Equipment.DataIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.EquipmentPiece
{
    public interface IEquipmentPieceService
    {
        public List<Models.EquipmentPiece> GetAllEquipmentPieces() { return null; }
        public EquipmentPieceDataIn getEquipmentPiece(int id) { return null; }
    }
}