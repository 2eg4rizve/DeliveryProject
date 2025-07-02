namespace DeliveryProject.Models
{
    public class ConnectTruckAndProducts
    {
        public int Id { get; set; }
        public string TruckId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
    }
}
