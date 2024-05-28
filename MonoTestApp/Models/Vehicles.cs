


namespace Vehicles.Models
{
    public class Vehicles
    {
        public int Id{get;set; }
        public required string Manufacturer {get;set; }
        public required string Model {get;set; }
        public  string? EngineType {get;set; }
        public required string Registration{get;set; }
        public int YearOfManufacture{get;set; }

        public Vehicles()
        {
            
        }

    }
}