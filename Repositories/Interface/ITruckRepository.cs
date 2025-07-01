// Repositories/Interface/ITruckRepository.cs
using DeliveryProject.Models;

namespace DeliveryProject.Repositories.Interface
{
    public interface ITruckRepository
    {
        Task<Truck> CreateTruck(Truck truck);
        Task<Truck> UpdateTruck(Truck truck);
        Task<Truck> GetTruckById(int id);
        Task<List<Truck>> GetAllTrucks();
    }
}

