// Repositories/Repository/TruckRepository.cs
using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace DeliveryProject.Repositories.Repository
{
    public class TruckRepository : ITruckRepository
    {
        private readonly DeliveryProjectContext _context;

        public TruckRepository(DeliveryProjectContext context)
        {
            _context = context;
        }

        public async Task<Truck> CreateTruck(Truck truck)
        {
            var entry = await _context.Trucks.AddAsync(truck);
            await _context.SaveChangesAsync();
            return entry.Entity;
        }

        public async Task<Truck> UpdateTruck(Truck truck)
        {
            _context.Trucks.Update(truck);
            await _context.SaveChangesAsync();
            return truck;
        }

        public async Task<Truck> GetTruckById(int id)
        {
            return await _context.Trucks.FindAsync(id);
        }

        public async Task<List<Truck>> GetAllTrucks()
        {
            return await _context.Trucks.ToListAsync();
        }
    }
}
