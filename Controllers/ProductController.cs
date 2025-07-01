using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Managers.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryProject.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _manager;

        public ProductController(IProductManager manager)
        {
            _manager = manager;
        }

        [HttpPost("create-product")]
        public async Task<IActionResult> CreateProduct(CreateProductRequestEntity request)
        {
            var response = await _manager.CreateProduct(request);
            return Ok(response);
        }

        [HttpPost("update-product")]
        public async Task<IActionResult> UpdateProduct(UpdateProductRequestEntity request)
        {
            var response = await _manager.UpdateProduct(request);
            return Ok(response);
        }

        [HttpPost("get-all-products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _manager.GetAllProducts();
            return Ok(response);
        }

        [HttpDelete("delete-product/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var response = await _manager.DeleteProduct(id);
            return Ok(response);
        }
    }
}
