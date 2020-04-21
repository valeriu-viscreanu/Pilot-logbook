using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logbook.DataLayer
{
    public class Flights
    {
        [Key]
        public int FlightId { get; set; }
        public Aircraft Aircraft { get; set; }
        public DateTime TakeoffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public List<User> Pilots { get; set; }


    }
}
