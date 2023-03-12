namespace FlightLog.ViewModel
{
    public class Flight
    {
        public Aircraft Aircraft { get; set; }
        public DateTime TakeoffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public string[] Pilots { get; set; }
    }
}
