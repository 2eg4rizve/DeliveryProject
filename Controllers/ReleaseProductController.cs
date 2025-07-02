using DeliveryProject.Managers.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeliveryProject.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReleaseProductController : ControllerBase
    {
        private readonly IReleaseProductManager _manager;

        public ReleaseProductController(IReleaseProductManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllSubmit")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _manager.GetAllAsync();
            return Ok(response);
        }

        [HttpPost("submitAll")]
        public async Task<IActionResult> SaveAll()
        {
            var response = await _manager.SaveAllAsync();
            return Ok(response);
        }


    }
}
