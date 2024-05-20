using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;

namespace DiamonShop.Data.Services
{
    public class DiamondService : IDiamondService
    {
        private readonly IRepositoryManager _repositoryManager;
        public DiamondService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<IEnumerable<Diamond>> GetAllDiamond()
        {
            try
            {
                //var diamonds = await _repositoryManager.Diamond.GetAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    }
}
