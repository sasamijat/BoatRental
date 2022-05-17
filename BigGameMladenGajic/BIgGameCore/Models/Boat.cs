using BIgGameCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigGame.Models
{
    public class Boat
    {
        public int BoatID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public float Length { get; set; }
        public int Year { get; set; }
        public int PassangerCapacity { get; set; }
        public int SleepCapacity { get; set; }
        public float FuelCapacity { get; set; }
        public int BedCount { get; set; }
        public string Desctription { get; set; }

        public int OwnerID { get; set; }
        public User Owner { get; set; }
        
        [JsonIgnore]
        public virtual IList<BoatImage> BoatImages { get; set; }

        [JsonIgnore]
        public virtual IList<BoatAvailability> boatAvailabilities { get; set; }
    }
}