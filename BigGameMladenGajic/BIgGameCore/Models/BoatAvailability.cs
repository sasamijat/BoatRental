using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BigGame.Models
{
    public class BoatAvailability
    {
        public int BoatAvailabilityID { get; set; }

        public int BoatID { get; set; }

        [JsonIgnore]
        public virtual Boat Boat { get; set; }

        public string Location { get; set; }

        public float Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual IList<Reservation> Reservations { get; set; }
    }
}