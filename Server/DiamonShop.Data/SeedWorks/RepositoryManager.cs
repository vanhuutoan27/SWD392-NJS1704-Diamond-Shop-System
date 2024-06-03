using DiamonShop.Core.Repository;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Data.Repository;

namespace DiamonShop.Data.SeedWorks
{

    public class RepositoryManager : IRepositoryManager
    {
        private readonly DiamondContext _context;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IDiamondRepository> _diamondRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IJewelryRepository> _jewelryRepository;
        public RepositoryManager(DiamondContext context)
        {
            _context = context;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
            _diamondRepository = new Lazy<IDiamondRepository>(() => new DiamondRepository(context));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _jewelryRepository = new Lazy<IJewelryRepository>(() => new JewelryRepository(context));
        }
        public IProductRepository Product => _productRepository.Value;

        public IDiamondRepository Diamond => _diamondRepository.Value;

        public IUserRepository User => _userRepository.Value;


        public IJewelryRepository Jewelry => _jewelryRepository.Value;

        public async Task<int> SaveAsync()
    }
}
