using System.ComponentModel.DataAnnotations;

namespace Logbook.DataLayer
{
    public class AircraftType
    {
        [Key]
        public int AircraftTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
