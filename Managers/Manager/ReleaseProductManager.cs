using DeliveryProject.Entities.ResponseEntity;
using DeliveryProject.Managers.Interface;
using DeliveryProject.Repositories.Interface;
using System.Threading.Tasks;

namespace DeliveryProject.Managers.Manager
{
    public class ReleaseProductManager : IReleaseProductManager
    {
        private readonly IReleaseProductRepository _repository;

        public ReleaseProductManager(IReleaseProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<CommonResponse> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();

            return new CommonResponse
            {
                status_code = 200,
                message = "Success",
                status = "OK",
                data = data
            };
        }

        public async Task<CommonResponse> SaveAllAsync()
        {
            await _repository.SaveAllAsync();

            return new CommonResponse
            {
                status_code = 200,
                message = "Data pushed to ReleaseProduct successfully.",
                status = "OK"
            };
        }
    }
}
