using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BoatsMontenegro.Models
{
    public class Boat
    {    
        [Key]
        public int BoatID { get; set; }  //Primary key
        public string Name { get; set; }
        public string Size { get; set; }
        public int Capacity { get; set; }
        public string Engine { get; set; }
        public string FuelConsumption { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

    }
}