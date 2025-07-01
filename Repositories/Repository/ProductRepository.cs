using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace DeliveryProject.Repositories.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DeliveryProjectContext _dbContext;

        public ProductRepository(DeliveryProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            var created = await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return created.Entity;
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null) return false;

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
