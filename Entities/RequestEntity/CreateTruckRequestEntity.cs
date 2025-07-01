// Entities/RequestEntity/CreateTruckRequestEntity.cs
namespace DeliveryProject.Entities.RequestEntity
{
    public class CreateTruckRequestEntity
    {
        public string TruckId { get; set; } = null!;
        public string TruckRegistration { get; set; } = null!;
        public string TruckDriverName { get; set; } = null!;
        public string TruckDriverMobile { get; set; } = null!;
    }
}
