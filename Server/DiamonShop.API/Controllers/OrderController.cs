﻿using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.SeedWorks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

    }
}
