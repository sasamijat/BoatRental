using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.User.DataOut
{
    public class EmployeeDataOut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public EmployeeDataOut() { }
        public EmployeeDataOut(int id,string name,string lastname,string username) {
        
            Id = id;
            Name = name;
            LastName = lastname;
            UserName = username;
        }

    }
}
