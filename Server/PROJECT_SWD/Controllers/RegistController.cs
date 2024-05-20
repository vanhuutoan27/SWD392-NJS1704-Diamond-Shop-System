using BussinessLogic.RequestModel;
using BussinessLogic.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace PROJECT_SWD.Controllers
{
    public class RegistController : ControllerBase
    {


        private readonly RegisterService _registerService;

        public RegistController( RegisterService registerService)
        {

            _registerService = registerService;
        }
        [HttpPost]
        [Route("Regist")]
        public async Task<IActionResult> Regist( [FromBody]RegistRequests req )
        {
            if (!ModelState.IsValid)   
            {
                return BadRequest(ModelState);
            }

            var response = await _registerService.RegistUser(req);

            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
