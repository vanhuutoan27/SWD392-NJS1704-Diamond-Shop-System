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
        public RepositoryManager(DiamondContext context)
        {
            _context = context;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
            _diamondRepository = new Lazy<IDiamondRepository>(() => new DiamondRepository(context));

        }
        public IProductRepository Product => _productRepository.Value;

        public IDiamondRepository Diamond => _diamondRepository.Value;

        public async Task<int> Save()
        {
            return _context.SaveChanges();
        }
    }
}
 