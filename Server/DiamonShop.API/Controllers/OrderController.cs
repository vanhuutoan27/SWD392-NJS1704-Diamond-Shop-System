using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.SeedWorks.Constants;
using DiamonShop.Core.Shared.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        ResultModel res;

        public OrderController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            res = new ResultModel();
        }

        [HttpPost("create")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<ResultModel>> CreateOrder([FromBody] CreateOrderRequest request)
        {
            var order = await _serviceManager.OrderService.CreateOrder(request);
            if (order == null)
            {
                res.IsSuccess = false;
                res.Message = "Create Fail!";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Create Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = order.OrderId;
            return res;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<ActionResult<ResultModel>> GetAllOrders()
        {

            var orders = await _serviceManager.OrderService.GetAllOrders();
            if (orders == null)
            {
                res.IsSuccess = false;
                res.Message = "Not Found!";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Create Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = orders;

            return res;
        }
        [HttpGet("{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<ResultModel>> GetOrderById(Guid id)
        {
            var order = await _serviceManager.OrderService.GetOrderByIdAsync(id);
            if (order == null)
            {
                res.IsSuccess = false;
                res.Message = "Not Found!";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = order;
            return res;
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<ResultModel>> DeleteOrderById(Guid id)
        {
            await _serviceManager.OrderService.DeleteOrder(id);
            res.IsSuccess = true;
            res.Message = "Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = null;
            return res;
        }

        [HttpGet("by-customer/{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<ResultModel>> GetOrderByCustomerId(Guid id)
        {
            var result = await _serviceManager.OrderService.GetOrderByCustomerIdAsync(id);
            if (result == null)
            {
                res.IsSuccess = false;
                res.Message = "Not Found!";
                res.Code = (int)StatusCodes.Status500InternalServerError;
                return res;
            }
            res.IsSuccess = true;
            res.Message = "Successful";
            res.Code = (int)HttpStatusCode.OK;
            res.Data = result;
            return res;
        }

        [HttpPut("Change-status-order/{id}")]
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<ActionResult<ResultModel>> ChangeOrderStatus(Guid id, OrderStatus orderStatus)
        {
            var result = await _serviceManager.OrderService.ChangeOrderStatusAsync(id, orderStatus);
            if (!result)
            {
                res.IsSuccess = false;
                res.Message = "Update Fail!";
                res.Code = 500;
                return res;
            }
            res.IsSuccess = false;
            res.Message = "Update Succesful!";
            res.Code = (int)StatusCodes.Status200OK;
            return res;
        }

    }
}
