using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeliveryProject.Repositories.Repository
{
    public class ReleaseProductRepository : IReleaseProductRepository
    {
        private readonly DeliveryProjectContext _context;

        public ReleaseProductRepository(DeliveryProjectContext context)
        {
            _context = context;
        }

        public async Task<List<ReleaseProduct>> GetAllAsync()
        {
            return await _context.ReleaseProduct.ToListAsync();
        }

        public async Task SaveAllAsync()
        {
            var data = await (from 
                                   cp in _context.ConnectTruckAndProducts
                              join 
                                   t in _context.Trucks on cp.TruckId equals t.TruckId
                              join 
                                   p in _context.Products on cp.ProductId equals p.ProductId
                              select new ReleaseProduct
                              {
                                  TruckId = cp.TruckId,
                                  TruckRegistration = t.TruckRegistration,
                                  TruckDriverName = t.TruckDriverName,
                                  TruckDriverMobile = t.TruckDriverMobile,
                                  ProductId = cp.ProductId,
                                  ProductName = p.ProductName
                              }).ToListAsync();

            await _context.ReleaseProduct.AddRangeAsync(data);
            await _context.SaveChangesAsync();

            var DeleteConnectTruckAndProductsData = await _context.ConnectTruckAndProducts.ToListAsync();
            _context.ConnectTruckAndProducts.RemoveRange(DeleteConnectTruckAndProductsData);
            await _context.SaveChangesAsync();


            var DeleteTruckData = await _context.Trucks.ToListAsync();
            _context.Trucks.RemoveRange(DeleteTruckData);
            await _context.SaveChangesAsync();


            var DeleteProductsData = await _context.Products.ToListAsync();
            _context.Products.RemoveRange(DeleteProductsData);
            await _context.SaveChangesAsync();


        }
    }
}
