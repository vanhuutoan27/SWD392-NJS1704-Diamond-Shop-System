using AutoMapper;
using DiamonShop.Core.Models;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.SeedWorks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiamonShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class JewelryController : ControllerBase
    {
        ResultModel res;
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;

        public JewelryController(IServiceManager serviceManager, IMapper mapper)
        {
            _service = serviceManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllJewelries()
        {
            var listJewelry = await _service.JewelryService.GetAllJewelries();
            if (listJewelry == null)
            {
                res = new ResultModel
                {
                    IsSuccess = true,
                    Message = "Not found.",
                    Code = (int)HttpStatusCode.NotFound,
                };
            }
            res = new ResultModel
            {
                IsSuccess = true,
                Message = "Successfully",
                Code = (int)HttpStatusCode.OK,
                Data = listJewelry
            };
            return res;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ResultModel>> GetJewelryById(Guid id)
        {
            var listJewelry = await _service.JewelryService.GetJewelryById(id);
            if (listJewelry == null)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.NotFound,
                    Message = "Jewelry isn't exist."
                };
                return res;
            }
            res = new ResultModel
            {
                IsSuccess = true,
                Code = (int)HttpStatusCode.NotFound,
                Data = listJewelry
            };
            return res;
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateJewelry([FromBody] CreateUpdateJewelryRequest createUpdateJewelry)
        {
            if (!ModelState.IsValid)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.BadRequest,
                };
            }
            var result = await _service.JewelryService.CreateJewelry(createUpdateJewelry);
            if (result == null)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.NotFound,
                    Message = "Jewelry isn't exist."
                };
            }
            res = new ResultModel
            {
                IsSuccess = true,
                Code = (int)HttpStatusCode.OK,
                Message = "Create succesfully."
            };
            return res;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid id)
        {
            if (id == null)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.BadRequest,
                    Message = "Jewelry isn't exist"
                };
                return res;
            }
            await _service.JewelryService.DeleteJewelry(id);
            res = new ResultModel
            {
                IsSuccess = true,
                Code = (int)HttpStatusCode.OK,
                Message = "Delete successfully."
            };
            return res;
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ResultModel>> Update(Guid id, CreateUpdateJewelryRequest jewelryDto)
        {
            //if (id != jewelryDto.JewelryId)
            //{
            //    res = new ResultModel
            //    {
            //        IsSuccess = false,
            //        Code = (int)HttpStatusCode.BadRequest,
            //        Message = "Jewelry isn't exist"
            //    };
            //    return res;
            //}
            var update = await _service.JewelryService.UpdateJewelry(id, jewelryDto);
            if (!update)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.NotFound,
                    Message = "Update fail."
                };
                return res;
            }
            res = new ResultModel
            {
                IsSuccess = true,
                Code = (int)HttpStatusCode.OK,
                Message = "Update successfully"
            };
            return res;
        }

        [HttpPut("change-status/{id}")]
        public async Task<ActionResult<ResultModel>> ChangeStatus(Guid id)
        {
            var result = await _service.JewelryService.ChangeStatusAsync(id);
            if (!result)
            {
                res = new ResultModel
                {
                    IsSuccess = false,
                    Code = (int)HttpStatusCode.NotFound,
                    Message = "Update fail."
                };
                return res;
            }
            res = new ResultModel
            {
                IsSuccess = true,
                Code = (int)HttpStatusCode.OK,
                Message = "Update successfully"
            };
            return res;
        }
    }
}
