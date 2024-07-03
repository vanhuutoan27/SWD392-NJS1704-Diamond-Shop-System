using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.SeedWorks;

namespace DiamonShop.Core.Repository
{
    public interface IInvoiceRepository : IRepository<Invoice, Guid>
    {
        Task<IEnumerable<Invoice>> GetAllInvoiceAsync();
        Task<IEnumerable<Invoice>> GetInvoiceByUserId(Guid userId);
        Task<Invoice> GetInvoiceById(Guid id);
    }
}
