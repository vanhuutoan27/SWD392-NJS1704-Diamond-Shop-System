using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Core.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonShop.Data.Services
{
    public class JewelryService : IJewelryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public JewelryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreateUpdateJewelryRequest> CreateJewelry(CreateUpdateJewelryRequest createJewelryDto)
        {
            var productId = Guid.NewGuid();
            var productName = createJewelryDto.Name;

            var newJewelry = new Jewelry()
            {
                JewelryId = productId,
                Name = productName,
                ProductType = createJewelryDto.ProductType,
                MainStoneSize = createJewelryDto.MainStoneSize,
                sideStoneType = createJewelryDto.SideStoneType,
                sideStoneQuantity = createJewelryDto.SideStoneQuantity,
                StoneWeight = createJewelryDto.StoneWeight,
                GoldType = createJewelryDto.GoldType,
                GoldKarat = createJewelryDto.GoldKarat,
                GoldWeight = createJewelryDto.GoldWeight,
                Price = createJewelryDto.Price
            };
            _repositoryManager.Jewelry.Add(newJewelry);
            Product product = new Product()
            {
                ProductId = productId,
                Name = productName,
                Price = createJewelryDto.Price,
                CategoryId = new Guid("816F2393-683E-428C-A4BB-2BA6E2E3F791"),
                Status = EnumStatus.Status.Active,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            _repositoryManager.Product.Add(product);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateUpdateJewelryRequest>(newJewelry);
            return result;
        }

        public async Task<bool> DeleteJewelry(Guid id)
        {
            var jewelry = await _repositoryManager.Jewelry.GetByIdAsync(id);
            if (jewelry == null)
            {
                return false;
            }
            _repositoryManager.Jewelry.Remove(jewelry);

            var product = await _repositoryManager.Product.GetByIdAsync(id);
            if (product == null)
            {
                return false;
            }
            _repositoryManager.Product.Remove(product);
            _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<Jewelry>> GetAllJewelries()
        {
            var listJewelry = await _repositoryManager.Jewelry.GetAllAsync();
            return listJewelry;
        }

        public async Task<Jewelry> GetJewelryById(Guid id)
        {
            return await _repositoryManager.Jewelry.GetByIdAsync(id);
        }

        public async Task<bool> UpdateJewelry(Guid id, CreateUpdateJewelryRequest jewelryDto)
        {
            var updateJewelry = await _repositoryManager.Jewelry.GetByIdAsync(id);
            if (updateJewelry == null)
            {
                return false;
            }

            updateJewelry.Name = jewelryDto.Name;
            updateJewelry.ProductType = jewelryDto.ProductType;
            updateJewelry.MainStoneSize = jewelryDto.MainStoneSize;
            updateJewelry.sideStoneType = jewelryDto.SideStoneType;
            updateJewelry.sideStoneQuantity = jewelryDto.SideStoneQuantity;
            updateJewelry.StoneWeight = jewelryDto.StoneWeight;
            updateJewelry.GoldType = jewelryDto.GoldType;
            updateJewelry.GoldKarat = jewelryDto.GoldKarat;
            updateJewelry.GoldWeight = jewelryDto.GoldWeight;
            updateJewelry.Price = jewelryDto.Price;
            _repositoryManager.Jewelry.UpdateJewelry(id, updateJewelry);

            var product = new Product()
            {
                Name = jewelryDto.Name
            };
            _repositoryManager.Product.UpdateProduct(id, product);

            return true;
        }
    }
}

