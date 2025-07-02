using DeliveryProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryProject.Repositories.Interface
{
    public interface IConnectTruckAndProductsRepository
    {
        Task<ConnectTruckAndProducts> CreateConnect(ConnectTruckAndProducts connect);
        Task<ConnectTruckAndProducts?> GetConnectById(int id);
        Task<List<ConnectTruckAndProducts>> GetAllConnects();
        Task<ConnectTruckAndProducts> UpdateConnect(ConnectTruckAndProducts connect);
        Task<bool> DeleteConnect(int id);
    }
}
