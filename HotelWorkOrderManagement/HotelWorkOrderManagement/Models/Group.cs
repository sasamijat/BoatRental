using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class Group : BaseEntity
    {
        
        public string Name { get; set; }
        public string Domain { get; set; }
        public int MembersCount { get; set; }
        
        public IList<Member> Members { get; set; }
        public ICollection<Task> Tasks { get; set; }

    }
}
