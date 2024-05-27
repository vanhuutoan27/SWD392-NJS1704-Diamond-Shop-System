using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
