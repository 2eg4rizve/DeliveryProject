// Managers/Manager/TruckManager.cs
using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;
using DeliveryProject.Managers.Interface;
using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;

namespace DeliveryProject.Managers.Manager
{
    public class TruckManager : ITruckManager
    {
        private readonly ITruckRepository _repository;

        public TruckManager(ITruckRepository repository)
        {
            _repository = repository;
        }

        public async Task<CommonResponse> CreateTruck(CreateTruckRequestEntity truck)
        {
            var response = new CommonResponse();
            try
            {
                var created = await _repository.CreateTruck(new Truck
                {
                    TruckId = truck.TruckId,
                    TruckRegistration = truck.TruckRegistration,
                    TruckDriverName = truck.TruckDriverName,
                    TruckDriverMobile = truck.TruckDriverMobile
                });

                response.status_code = 200;
                response.message = "Truck created";
                response.data = created;
                return response;
            }
            catch
            {
                response.status_code = 500;
                response.message = "Error creating truck";
                return response;
            }
        }

        public async Task<CommonResponse> UpdateTruck(UpdateTruckRequestEntity truck)
        {
            var response = new CommonResponse();
            try
            {
                var existing = await _repository.GetTruckById(truck.Id);
                if (existing == null)
                {
                    response.status_code = 404;
                    response.message = "Truck not found";
                    return response;
                }

                existing.TruckId = truck.TruckId;
                existing.TruckRegistration = truck.TruckRegistration;
                existing.TruckDriverName = truck.TruckDriverName;
                existing.TruckDriverMobile = truck.TruckDriverMobile;

                var updated = await _repository.UpdateTruck(existing);

                response.status_code = 200;
                response.message = "Truck updated";
                response.data = updated;
                return response;
            }
            catch
            {
                response.status_code = 500;
                response.message = "Error updating truck";
                return response;
            }
        }

        public async Task<CommonResponse> GetTruckById(GetTruckByIdRequestEntity request)
        {
            var truck = await _repository.GetTruckById(request.Id);
            if (truck == null)
                return new CommonResponse { status_code = 404, message = "Truck not found" };

            return new CommonResponse { status_code = 200, message = "Truck found", data = truck };
        }

        public async Task<CommonResponse> GetAllTrucks()
        {
            var trucks = await _repository.GetAllTrucks();
            return new CommonResponse
            {
                status_code = 200,
                message = "All trucks fetched",
                data = trucks
            };
        }
    }
}
