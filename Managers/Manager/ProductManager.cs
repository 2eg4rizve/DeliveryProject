using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;
using DeliveryProject.Managers.Interface;
using DeliveryProject.Models;
using DeliveryProject.Repositories.Interface;

namespace DeliveryProject.Managers.Manager
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _repository;

        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<CommonResponse> CreateProduct(CreateProductRequestEntity request)
        {
            var response = new CommonResponse();

            var product = new Product
            {
                ProductId = request.ProductId,
                ProductName = request.ProductName
            };

            var result = await _repository.CreateProduct(product);
            response.status_code = 200;
            response.message = "Product created successfully";
            response.data = result;
            return response;
        }

        public async Task<CommonResponse> UpdateProduct(UpdateProductRequestEntity request)
        {
            var response = new CommonResponse();

            var existing = await _repository.GetProductById(request.Id);
            if (existing == null)
            {
                response.status_code = 404;
                response.message = "Product not found";
                return response;
            }

            existing.ProductId = request.ProductId;
            existing.ProductName = request.ProductName;

            var result = await _repository.UpdateProduct(existing);
            response.status_code = 200;
            response.message = "Product updated successfully";
            response.data = result;
            return response;
        }

        public async Task<CommonResponse> GetAllProducts()
        {
            var response = new CommonResponse();
            var products = await _repository.GetAllProducts();

            response.status_code = 200;
            response.message = "Products retrieved successfully";
            response.data = products;
            return response;
        }

        public async Task<CommonResponse> DeleteProduct(int id)
        {
            var response = new CommonResponse();
            var deleted = await _repository.DeleteProduct(id);

            if (!deleted)
            {
                response.status_code = 404;
                response.message = "Product not found";
                return response;
            }

            response.status_code = 200;
            response.message = "Product deleted successfully";
            return response;
        }
    }
}
