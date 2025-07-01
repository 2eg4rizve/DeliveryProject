using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Entities.ResponseEntity;

namespace DeliveryProject.Managers.Interface
{
    public interface IProductManager
    {
        Task<CommonResponse> CreateProduct(CreateProductRequestEntity request);
        Task<CommonResponse> UpdateProduct(UpdateProductRequestEntity request);
        Task<CommonResponse> GetAllProducts();
        Task<CommonResponse> DeleteProduct(int id);
    }
}
