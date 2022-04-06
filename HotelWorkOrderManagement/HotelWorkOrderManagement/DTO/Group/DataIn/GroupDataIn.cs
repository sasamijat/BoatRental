using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Group.DataIn
{
    public class GroupDataIn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int MembersCount { get; set; }

        public GroupDataIn() { }

        public GroupDataIn(Models.Group group)
        {
            Id = group.Id;
            Name = group.Name;
            Domain = group.Domain;
            MembersCount = group.MembersCount;
        }
    }
}
