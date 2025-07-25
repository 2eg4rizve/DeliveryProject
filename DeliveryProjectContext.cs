﻿

// DeliveryProjectContext.cs
using DeliveryProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DeliveryProject
{
    public class DeliveryProjectContext : DbContext
    {
        public DeliveryProjectContext(DbContextOptions<DeliveryProjectContext> options) : base(options) { }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ConnectTruckAndProducts> ConnectTruckAndProducts { get; set; }

        public DbSet<ReleaseProduct> ReleaseProduct { get; set; }


    }
}
