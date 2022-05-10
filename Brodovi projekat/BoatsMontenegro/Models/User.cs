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



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string FirstName { get; set; }



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string LastName { get; set; }

     

        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        //[RegularExpression("^\\S+@\\S+\\.\\S+$")]
        public string Email { get; set; }



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string PhoneNumber { get; set; }



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string PersonalIdNumber { get; set; }



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string Username { get; set; }



        //[Required(ErrorMessage = "Ovo polje mora biti popunjeno.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }


        //[DataType(DataType.Password)]
        //[Compare("Password",ErrorMessage = "Ovo polje mora biti popunjeno.")]
        public string ConfirmPassword { get; set; }
    

       
        public Role Role { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Boat> Boats { get; set; } //ownership


        public bool RememberMe { get; set; }
        public bool IsActive { get; set; }
        

    }
}