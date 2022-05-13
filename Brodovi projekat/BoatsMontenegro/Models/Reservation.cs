using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoatsMontenegro.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }  //Primary key
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool NeedCaptain { get; set; }

        
        public virtual Boat Boat { get; set; }
        
        public User ReservedBy { get; set; }
       
    }
}