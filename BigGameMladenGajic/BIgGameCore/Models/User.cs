using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigGame.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }
        
        public string? ProfileImage { get; set; }

        public string FirstAndLastName() {
            return FirstName + " " + LastName;
        }
        public virtual IList<Boat> Boats { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }



    }
}