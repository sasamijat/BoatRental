using HotelWorkOrderManagement.DTO.Group.DataIn;
using HotelWorkOrderManagement.DTO.Group.DataOut;
using HotelWorkOrderManagement.DTO.User.DataOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.Group
{
    public interface IGroupService
    {

        public GroupDataIn getGroup(int id) { return null; }

        public List<GroupDataOut> getMyGroups(int id) { return null; }

        public List<EmployeeDataOut> getAllEmployeesExceptGroupMembers(int groupId) { return null; }
        public void addMember(int id,int groupId) { }
        public void removeMember(int id, int groupId) { }


    }
}
