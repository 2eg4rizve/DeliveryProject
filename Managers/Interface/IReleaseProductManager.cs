using DeliveryProject.Entities.ResponseEntity;
using System.Threading.Tasks;

namespace DeliveryProject.Managers.Interface
{
    public interface IReleaseProductManager
    {
        Task<CommonResponse> GetAllAsync();

        Task<CommonResponse> SaveAllAsync();
    }
}
