using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryProject.Models
{
    [Table("ReleaseProduct")]
    public class ReleaseProduct
    {
        [Key]
        public int Id { get; set; }

        public string TruckId { get; set; }
        public string TruckRegistration { get; set; }
        public string TruckDriverName { get; set; }
        public string TruckDriverMobile { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
