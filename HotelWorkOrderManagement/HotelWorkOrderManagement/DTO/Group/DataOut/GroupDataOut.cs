using HotelWorkOrderManagement.DTO.User.DataOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Group.DataOut
{
    public class GroupDataOut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int MembersCount { get; set; }
        public Models.User Leader { get; set; }
        public bool SelfTaskAssign { get; set; }
        public List<EmployeeDataOut> Members = new List<EmployeeDataOut>();


        public GroupDataOut() { }

        public GroupDataOut(Models.Group group,Models.User Leader,List<EmployeeDataOut>? members)
        {
            this.Leader= Leader;
            Id = group.Id;
            Name = group.Name;
            Domain = group.Domain;
            SelfTaskAssign = group.SelfTaskAssign;
            MembersCount = group.MembersCount;
            Members.AddRange(members);
        }
    }

}
