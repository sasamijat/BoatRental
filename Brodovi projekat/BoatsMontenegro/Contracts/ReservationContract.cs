using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoatsMontenegro.Contracts
{
    public class ReservationContract
    {
        public int id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string NeedCaptain { get; set; }
    }
}