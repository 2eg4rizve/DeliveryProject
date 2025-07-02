using DeliveryProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryProject.Repositories.Interface
{
    public interface IReleaseProductRepository
    {
        Task<List<ReleaseProduct>> GetAllAsync();

        Task SaveAllAsync();
    }
}
