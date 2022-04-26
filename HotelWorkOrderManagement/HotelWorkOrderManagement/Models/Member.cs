using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class Member : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }

        public bool Leader { get; set; }

        public Member() { }
        public Member(int userId,int groupId) {
       
            UserId = userId;
            GroupId = groupId;
        }
    }
    
}
