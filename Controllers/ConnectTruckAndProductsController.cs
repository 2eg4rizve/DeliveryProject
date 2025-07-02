using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Managers.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeliveryProject.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ConnectTruckAndProductsController : ControllerBase
    {
        private readonly IConnectTruckAndProductsManager _manager;

        public ConnectTruckAndProductsController(IConnectTruckAndProductsManager manager)
        {
            _manager = manager;
        }

        [HttpPost("create-connection")]
        public async Task<IActionResult> CreateConnection(CreateConnectTruckAndProductsRequestEntity request)
        {
            var response = await _manager.CreateConnect(request);
            return Ok(response);
        }

        [HttpPost("update-connection")]
        public async Task<IActionResult> UpdateConnection(UpdateConnectTruckAndProductsRequestEntity request)
        {
            var response = await _manager.UpdateConnect(request);
            return Ok(response);
        }

        [HttpPost("get-all-connections")]
        public async Task<IActionResult> GetAllConnections()
        {
            var response = await _manager.GetAllConnects();
            return Ok(response);
        }

        [HttpDelete("delete-connection/{id}")]
        public async Task<IActionResult> DeleteConnection(int id)
        {
            var response = await _manager.DeleteConnect(id);
            return Ok(response);
        }
    }
}
