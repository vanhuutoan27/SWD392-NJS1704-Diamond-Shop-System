using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Models.content.RequestModels;
using DiamonShop.Core.Models.content.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using DiamonShop.Core.Shared.Enum;

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
            var skudId = await _repositoryManager.Jewelry.GenerateSkuAsync();
            var newJewelry = new Jewelry()
            {
                JewelryId = productId,
                Name = productName,
                SkuID = skudId,
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
            var category = await _repositoryManager.Category.GetByNameAsync(createJewelryDto.ProductType);
            Product product = new Product()
            {
                ProductId = productId,
                Name = productName,
                Price = createJewelryDto.Price,
                CategoryId = category != null ? category.CategoryId : throw new ArgumentNullException(nameof(category),
                "Category cannot be null"),
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



        public async Task<IEnumerable<JewelryResponse>> GetAllJewelries()
        {
            var listJewelry = await _repositoryManager.Jewelry.GetAllJewelryAsync();
            var listJewelryResponse = _mapper.Map<IEnumerable<JewelryResponse>>(listJewelry);

            return listJewelryResponse;
        }

        public async Task<JewelryResponse> GetJewelryById(Guid id)
        {
            var jewelry = await _repositoryManager.Jewelry.GetJewelryAsync(id);
            return _mapper.Map<JewelryResponse>(jewelry);
        }

        public async Task<bool> UpdateJewelry(Guid id, CreateUpdateJewelryRequest jewelryDto)
        {
            var updateJewelry = await _repositoryManager.Jewelry.GetJewelryAsync(id);
            if (updateJewelry == null)
            {
                return false;
            }

            updateJewelry.Name = jewelryDto.Name;
            updateJewelry.MainStoneSize = jewelryDto.MainStoneSize;
            updateJewelry.sideStoneType = jewelryDto.SideStoneType;
            updateJewelry.sideStoneQuantity = jewelryDto.SideStoneQuantity;
            updateJewelry.StoneWeight = jewelryDto.StoneWeight;
            updateJewelry.GoldType = jewelryDto.GoldType;
            updateJewelry.GoldKarat = jewelryDto.GoldKarat;
            updateJewelry.GoldWeight = jewelryDto.GoldWeight;
            updateJewelry.Price = jewelryDto.Price;
            _repositoryManager.Jewelry.UpdateJewelry(id, updateJewelry);

            var product = await _repositoryManager.Product.GetByIdAsync(id);
            Category category = null;
            if (product == null) throw new ArgumentException("not found product");
            product.Name = jewelryDto.Name;
            if (product.Category.Name != jewelryDto.Name)
            {
                category = await _repositoryManager.Category.GetByNameAsync(jewelryDto.ProductType);

                product.CategoryId = category != null ? category.CategoryId : throw new ArgumentNullException(nameof(category),
                        "Category cannot be null");

            }
            _repositoryManager.Product.Update(product);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}

