using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoatsMontenegro.Models
{
    public class User
    {
        [Key]       
        public int UserID { get; set; }  //Primary key

        public string UserIdentifier { get; set; }

        [Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int RoleId { get; set; }



        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        //[RegularExpression("^\\S+@\\S+\\.\\S+$")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalIdNumber { get; set; }




        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Boat> Boats { get; set; } //ownership

        

    }
}