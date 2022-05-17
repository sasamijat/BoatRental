using BigGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BIgGameCore.Models
{
    public class BoatImage
    {
        public int id { get; set; }
        public int BoatId { get; set; }

        [JsonIgnore]
        public Boat Boat { get; set; }

        public string Image { get; set; }
    }
}
