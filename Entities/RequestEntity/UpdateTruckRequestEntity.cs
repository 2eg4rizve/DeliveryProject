// Entities/RequestEntity/UpdateTruckRequestEntity.cs
namespace DeliveryProject.Entities.RequestEntity
{
    public class UpdateTruckRequestEntity
    {
        public int Id { get; set; }
        public string TruckId { get; set; } = null!;
        public string TruckRegistration { get; set; } = null!;
        public string TruckDriverName { get; set; } = null!;
        public string TruckDriverMobile { get; set; } = null!;
    }
}
