using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class Comment : BaseEntity
    {
       
       
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public Task Task { get; set; }
        public int TaskID { get; set; }
        public User CreatedBy { get; set; }
        public int CreatedById { get; set; }



    }
}
