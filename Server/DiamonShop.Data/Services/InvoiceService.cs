using AutoMapper;
using DiamonShop.Core.Domain.Identity;
using DiamonShop.Core.Models.content.Respone;
using DiamonShop.Core.SeedWorks;
using DiamonShop.Core.services;
using Microsoft.AspNetCore.Identity;

namespace DiamonShop.Data.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public InvoiceService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IEnumerable<InvoiceResponse>> GetAllInvoiceAsync()
        {
            var invoices = await _repositoryManager.Invoice.GetAllInvoiceAsync();
            if (invoices == null) throw new Exception("Not Found Invoices");
            return _mapper.Map<IEnumerable<InvoiceResponse>>(invoices);
        }

        public async Task<IEnumerable<InvoiceResponse>> GetInvoiceByUserIdAsync(Guid userId)
        {
            var invoices = await _repositoryManager.Invoice.GetInvoiceByUserId(userId);
            if (invoices == null) throw new Exception("Not Found Invoices");
            return _mapper.Map<IEnumerable<InvoiceResponse>>(invoices);
        }
    }
}
