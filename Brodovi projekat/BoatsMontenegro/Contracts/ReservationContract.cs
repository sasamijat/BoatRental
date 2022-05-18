using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoatsMontenegro.Contracts
{
    public class ReservationContract
    {
        public int BoatID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool NeedCaptain { get; set; }
    }
}