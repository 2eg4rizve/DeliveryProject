using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryProject.Repositories.Repository
{
    public class ConnectTruckAndProductsRepository : IConnectTruckAndProductsRepository
    {
        private readonly DeliveryProjectContext _dbContext;

        public ConnectTruckAndProductsRepository(DeliveryProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ConnectTruckAndProducts> CreateConnect(ConnectTruckAndProducts connect)
        {
            var created = await _dbContext.ConnectTruckAndProducts.AddAsync(connect);
            await _dbContext.SaveChangesAsync();
            return created.Entity;
        }

        public async Task<bool> DeleteConnect(int id)
        {
            var connect = await _dbContext.ConnectTruckAndProducts.FindAsync(id);
            if (connect == null) return false;

            _dbContext.ConnectTruckAndProducts.Remove(connect);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<ConnectTruckAndProducts>> GetAllConnects()
        {
            return await _dbContext.ConnectTruckAndProducts.ToListAsync();
        }

        public async Task<ConnectTruckAndProducts?> GetConnectById(int id)
        {
            return await _dbContext.ConnectTruckAndProducts.FindAsync(id);
        }

        public async Task<ConnectTruckAndProducts> UpdateConnect(ConnectTruckAndProducts connect)
        {
            _dbContext.ConnectTruckAndProducts.Update(connect);
            await _dbContext.SaveChangesAsync();
            return connect;
        }
    }
}
