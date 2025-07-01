// Managers/Interface/ITruckManager.cs
using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;

namespace DeliveryProject.Managers.Interface
{
    public interface ITruckManager
    {
        Task<CommonResponse> CreateTruck(CreateTruckRequestEntity truck);
        Task<CommonResponse> UpdateTruck(UpdateTruckRequestEntity truck);
        Task<CommonResponse> GetTruckById(GetTruckByIdRequestEntity request);
        Task<CommonResponse> GetAllTrucks();
    }
}
