using HotelWorkOrderManagement.DTO.User.DataIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelWorkOrderManagement.Models
{
    public class User : BaseEntity
    {
       
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string? ProfileImage { get; set; }
        public Function Role { get; set; }
   

        public ICollection<Comment>? Comments { get; set; }
        public ICollection<TaskStateChange> TaskStateChanges { get; set; }
        public IList<Member> Members { get; set; }

        public ICollection<Task> TaskCreators { get; set; }
        public ICollection<Task> TaskAsignees { get; set; }
        public ICollection<EquipmentPiece> EquipmentPieces { get; set; }

        public enum Function
        {
            Maintainer,
            Housekeeper,
            Admin
        }

        public User() { }

        public User(UserDataIn user)
        {
            if (user.Id != null)
                Id = user.Id.Value;
            Name = user.Name;
            LastName = user.LastName;
            Username = user.UserName;
            Password = user.Password;
            Role = (Function)Enum.Parse(typeof(Function),user.Role);
        }

    }
}
