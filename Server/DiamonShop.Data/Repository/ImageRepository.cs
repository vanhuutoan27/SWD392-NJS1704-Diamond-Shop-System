using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;

namespace DiamonShop.Data.Repository
{
    public class ImageRepository : RepositoryBase<Image, Guid>, IImageRepository
    {
        public ImageRepository(DiamondContext context) : base(context)
        {

        }
    }
}
