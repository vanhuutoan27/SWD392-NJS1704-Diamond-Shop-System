using AutoMapper;
using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class DiamondService : IDiamondService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public DiamondService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Diamond>> GetAllDiamond()
        {
                var diamonds = await _repositoryManager.Diamond.GetAllAsync();
                return diamonds;
            
        }
    }
}
