using AutoMapper;
using DiamonShop.Core.Models;
using DiamonShop.Core.SeedWorks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly IMapper _mapper;
        ResultModel res;
        public InvoiceController(IServiceManager serviceManager,
            IMapper mapper)
        {
            _serviceManager = serviceManager;
            _mapper = mapper;
            res = new ResultModel();
        }

        //[HttpPost]
        //public async Task<ActionResult<ResultModel>> CreateInvoice()
        //{

        //}
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllInvoices()
        {
            var result = await _serviceManager.InvoiceService.GetAllInvoiceAsync();
            if (result == null)
            {
                res.IsSuccess = false;
                res.Message = "Not Found Invoice Lists";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = result;
            return res;
        }
        [HttpGet("user/{id}")]
        public async Task<ActionResult<ResultModel>> GetInvoicesByUserId(Guid id)
        {
            var result = await _serviceManager.InvoiceService.GetInvoiceByUserIdAsync(id);
            if (result == null)
            {
                res.IsSuccess = false;
                res.Message = "Not Found Invoice Lists";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = result;
            return res;
        }
    }
}
