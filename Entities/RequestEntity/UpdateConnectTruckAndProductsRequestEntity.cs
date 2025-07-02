namespace DeliveryProject.Entities.RequestEntity
{
    public class UpdateConnectTruckAndProductsRequestEntity
    {
        public int Id { get; set; }
        public string TruckId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
    }
}
