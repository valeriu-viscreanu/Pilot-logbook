using System.ComponentModel.DataAnnotations;

namespace Logbook.DataLayer
{
    public class Aircraft
    {
        [Key]
        public int AircraftId { get; set; }
        public string Registration { get; set; }
        public AircraftType Type { get; set; }
    }
}
