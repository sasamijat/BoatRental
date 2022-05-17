using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigGame.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public int BoatAvailabilityID { get; set; }

        public ReservationStatus status { get; set; }

        [JsonIgnore]
        public BoatAvailability BoatAvailability { get; set; }

        public DateTime startDateTime { get; set; }

        public DateTime endDateTime { get; set; }

        public double getTotalHours() {

            return endDateTime.Subtract(startDateTime).TotalHours;
        }

        public double getTotalPrice() {

            return getTotalHours() * BoatAvailability.Price;
        }
    }

    public enum ReservationStatus {
        ACTIVE,
        CANCELED,
        IN_PROGRESS
    }
}