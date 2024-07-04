using DiamonShop.Core.Domain.Content;
using DiamonShop.Core.Repository;
using DiamonShop.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.Data.Repository
{
    public class InvoiceRepository : RepositoryBase<Invoice, Guid>, IInvoiceRepository
    {
        public InvoiceRepository(DiamondContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Invoice>> GetAllInvoiceAsync()
        {
            return await _context.Invoices.AsNoTracking().AsQueryable()
                .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images)
                .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Jewelry)
                .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Diamond)

                .Include(i => i.User).ToListAsync();
        }

        public async Task<IEnumerable<Invoice>> GetInvoiceByUserId(Guid userId)
        {
            return await _context.Invoices.AsNoTracking().AsQueryable()
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images)
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Jewelry)
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Diamond)

           .Include(i => i.User).Where(i => i.UserId == userId).ToListAsync();
        }
        public async Task<Invoice> GetInvoiceById(Guid id)
        {
            return await _context.Invoices.AsNoTracking().AsQueryable()
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images)
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Jewelry)
           .Include(i => i.Order).ThenInclude(o => o.Items).ThenInclude(oi => oi.Product).ThenInclude(p => p.Diamond)

           .Include(i => i.User).FirstOrDefaultAsync(i => i.InvoiceId == id);
        }

    }
}
