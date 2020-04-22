using System.ComponentModel.DataAnnotations;

namespace Logbook.DataLayer
{
    public class AircraftType
    {
        [Key]
        public int AircraftTypeId { get; set; }
        public string ModelFullName { get; set; }
        public string Description { get; set; }
        public string WTC { get; set; }
        public string WTG { get; set; }
        public string Designator { get; set; }
        public string ManufacturerCode { get; set; }
        public int EngineCount { get; set; }
        public string EngineType { get; set; }

    }
}


//{
//        "ModelFullName": "Z-726 Universal",
//        "Description": "L1P",
//        "WTC": "L",
//        "WTG": null,
//        "Designator": "Z26",
//        "ManufacturerCode": "ZLIN",
//        "AircraftDescription": "LandPlane",
//        "EngineCount": "1",
//        "EngineType": "Piston"
//    },