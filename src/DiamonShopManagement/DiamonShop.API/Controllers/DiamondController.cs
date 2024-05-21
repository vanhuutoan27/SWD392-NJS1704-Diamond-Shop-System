using DiamonShop.Core.services;
using Microsoft.AspNetCore.Mvc;

namespace DiamonShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondController : ControllerBase
    {
        private readonly IServiceManager _services;
        public DiamondController(IServiceManager services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var diamonds = await _services.DiamondService.GetAllDiamond();
            return Ok(diamonds);
        }
    }
}
