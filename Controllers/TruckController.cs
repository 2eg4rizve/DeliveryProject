// Controllers/TruckController.cs
using DeliveryProject.Entities.RequestEntity;
using DeliveryProject.Managers.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryProject.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class TruckController : ControllerBase
    {
        private readonly ITruckManager _truckManager;

        public TruckController(ITruckManager truckManager)
        {
            _truckManager = truckManager;
        }

        [HttpPost("create-truck")]
        public async Task<IActionResult> CreateTruck([FromBody] CreateTruckRequestEntity truck)
        {
            return Ok(await _truckManager.CreateTruck(truck));
        }

        [HttpPost("update-truck")]
        public async Task<IActionResult> UpdateTruck([FromBody] UpdateTruckRequestEntity truck)
        {
            return Ok(await _truckManager.UpdateTruck(truck));
        }

        [HttpPost("get-truck-by-id")]
        public async Task<IActionResult> GetTruckById([FromBody] GetTruckByIdRequestEntity request)
        {
            return Ok(await _truckManager.GetTruckById(request));
        }

        [HttpPost("get-all-trucks")]
        public async Task<IActionResult> GetAllTrucks()
        {
            return Ok(await _truckManager.GetAllTrucks());
        }
    }
}
