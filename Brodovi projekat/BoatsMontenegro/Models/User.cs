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

       // [Required(ErrorMessage = "Ime je obavezno uneti")]
        public string Name { get; set; }


       // [Required(ErrorMessage = "Prezime je obavezno uneti")]
        public string Surname { get; set; }


       // [Required(ErrorMessage = "Email je obavezno uneti")]
       // [RegularExpression("^\\S+@\\S+\\.\\S+$")]
        public string Email { get; set; }

        
        public string PhoneNumber { get; set; }
        public string PersonalIdNumber { get; set; }


       // [Required(ErrorMessage = "Korisnicko ime je obavezno uneti")]
        public string Username { get; set; }


       //[Required(ErrorMessage = "Lozinku je obavezno uneti")]
       //[DataType(DataType.Password)]
        public string Password { get; set; }


       // [Compare("Password", ErrorMessage = "Potvrdite vasu lozinku")]
       // [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public int RoleId { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Boat> Boats { get; set; } //ownership
        
    }
}