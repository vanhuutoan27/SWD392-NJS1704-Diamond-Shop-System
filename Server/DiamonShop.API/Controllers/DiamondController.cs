using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.SeedWorks.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiamonShop.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
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
            if (diamonds == null)
            {
                return NotFound();
            }
            return Ok(diamonds);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDiamondbyId(Guid id)
        {
            try
            {
                var getdiamondbyId = await _services.DiamondService.GetDiamondbyId(id);
                if (getdiamondbyId == null)
                {
                    return BadRequest();
                }
                return Ok(getdiamondbyId);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        [HttpPut("{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]

        public async Task<IActionResult> UpdateDiamond(Guid id, [FromBody] UpdateDiamondRequest updateDiamondrequest)
        {


            var result = await _services.DiamondService.UpdateById(id, updateDiamondrequest);

            if (result == null)
            {

                return NotFound($"Diamond with id {id} not found.");
            }

            return NoContent();


        }
        [HttpPost]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]

        public async Task<IActionResult> CreateDiamond(CreateDiamondRequest createDiamondrequest)
        {


            var response = await _services.DiamondService.AddDiamond(createDiamondrequest);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpDelete]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<DiamondRespone>> RemoveDiamond(Guid id)
        {
            if (id != null)
            {
                _services.DiamondService.RemoveDiamondById(id);
            }

            return NoContent();

        }

        [HttpPut("chang-status/{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<IActionResult> ChangeStatus(Guid id)
        {
            var result = await _services.DiamondService.ChangeStatusAsync(id);
            if (!result)
            {
                return Problem();
            }
            return Ok();
        }
    }

}
