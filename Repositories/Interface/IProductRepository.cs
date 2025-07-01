using DeliveryProject.Models;

namespace DeliveryProject.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product?> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        Task<bool> DeleteProduct(int id);
    }
}
