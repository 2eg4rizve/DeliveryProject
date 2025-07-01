

// Models/Truck.cs
namespace DeliveryProject.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string TruckId { get; set; } = null!;
        public string TruckRegistration { get; set; } = null!;
        public string TruckDriverName { get; set; } = null!;
        public string TruckDriverMobile { get; set; } = null!;
    }
}
