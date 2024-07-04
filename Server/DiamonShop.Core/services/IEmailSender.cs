using DiamonShop.Core.Models.auth;

namespace DiamonShop.Core.services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}
