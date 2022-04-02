using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelWorkOrderManagement.DTO.User.DataIn
{
    public class UserDataIn
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public enum Function
        {
            Maintainer,
            Housekeeper,
            Admin
        }

        public UserDataIn() { }
        public UserDataIn(Models.User user)
        {
            Id = user.Id;
            Name = user.Name;
            LastName = user.LastName;
            UserName = user.Username;
            Password = user.Password;
            Role = user.Role.ToString();
        }

    }
}
