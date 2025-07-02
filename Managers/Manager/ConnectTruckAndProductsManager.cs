using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;
using DeliveryProject.Managers.Interface;
using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;
using System.Threading.Tasks;

namespace DeliveryProject.Managers.Manager
{
    public class ConnectTruckAndProductsManager : IConnectTruckAndProductsManager
    {
        private readonly IConnectTruckAndProductsRepository _repository;

        public ConnectTruckAndProductsManager(IConnectTruckAndProductsRepository repository)
        {
            _repository = repository;
        }

        public async Task<CommonResponse> CreateConnect(CreateConnectTruckAndProductsRequestEntity request)
        {
            var response = new CommonResponse();

            var connect = new ConnectTruckAndProducts
            {
                TruckId = request.TruckId,
                ProductId = request.ProductId
            };

            var result = await _repository.CreateConnect(connect);
            response.status_code = 200;
            response.message = "Connection created successfully";
            response.data = result;
            return response;
        }

        public async Task<CommonResponse> UpdateConnect(UpdateConnectTruckAndProductsRequestEntity request)
        {
            var response = new CommonResponse();

            var existing = await _repository.GetConnectById(request.Id);
            if (existing == null)
            {
                response.status_code = 404;
                response.message = "Connection not found";
                return response;
            }

            existing.TruckId = request.TruckId;
            existing.ProductId = request.ProductId;

            var result = await _repository.UpdateConnect(existing);
            response.status_code = 200;
            response.message = "Connection updated successfully";
            response.data = result;
            return response;
        }

        public async Task<CommonResponse> GetAllConnects()
        {
            var response = new CommonResponse();
            var connects = await _repository.GetAllConnects();

            response.status_code = 200;
            response.message = "Connections retrieved successfully";
            response.data = connects;
            return response;
        }

        public async Task<CommonResponse> DeleteConnect(int id)
        {
            var response = new CommonResponse();
            var deleted = await _repository.DeleteConnect(id);

            if (!deleted)
            {
                response.status_code = 404;
                response.message = "Connection not found";
                return response;
            }

            response.status_code = 200;
            response.message = "Connection deleted successfully";
            return response;
        }
    }
}
