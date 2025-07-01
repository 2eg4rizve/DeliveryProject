namespace DeliveryProject.Entities.RequestEntity
{
    public class UpdateProductRequestEntity
    {
        public int Id { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
    }
}
