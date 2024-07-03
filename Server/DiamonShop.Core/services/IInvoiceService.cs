using DiamonShop.Core.Models.content.Respone;

namespace DiamonShop.Core.services
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceResponse>> GetAllInvoiceAsync();
        Task<IEnumerable<InvoiceResponse>> GetInvoiceByUserIdAsync(Guid userId);
        Task<InvoiceResponse> GetInvoiceByIdAsync(Guid id);
    }
}
