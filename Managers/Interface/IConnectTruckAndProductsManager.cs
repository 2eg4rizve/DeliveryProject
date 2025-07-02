using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;
using System.Threading.Tasks;

namespace DeliveryProject.Managers.Interface
{
    public interface IConnectTruckAndProductsManager
    {
        Task<CommonResponse> CreateConnect(CreateConnectTruckAndProductsRequestEntity request);
        Task<CommonResponse> UpdateConnect(UpdateConnectTruckAndProductsRequestEntity request);
        Task<CommonResponse> GetAllConnects();
        Task<CommonResponse> DeleteConnect(int id);
    }
}
