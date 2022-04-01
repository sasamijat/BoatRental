using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class Member : BaseEntity
    {
        public User Technician { get; set; }
        public int TechnicianId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }

        public bool Leader { get; set; }
    }
}
