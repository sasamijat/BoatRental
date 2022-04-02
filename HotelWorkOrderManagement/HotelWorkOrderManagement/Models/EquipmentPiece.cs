﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class EquipmentPiece : BaseEntity
    {
       
        public string Name { get; set; }    
        public int NumOfInterventions { get; set; }
        public DateTime? InstalationDate { get; set; }
        public DateTime? LastIntervention { get; set; }
        public int? InstalatedById { get; set; }
        public User InstalatedBy { get; set; }


        public ICollection<Task> Tasks { get; set; }


    }
}