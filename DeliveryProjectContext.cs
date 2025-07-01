

// DeliveryProjectContext.cs
using DeliveryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryProject
{
    public class DeliveryProjectContext : DbContext
    {
        public DeliveryProjectContext(DbContextOptions<DeliveryProjectContext> options) : base(options) { }

        public DbSet<Truck> Trucks { get; set; }
    }
}
