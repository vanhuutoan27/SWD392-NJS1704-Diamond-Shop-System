namespace DiamonShop.Core.Models.auth
{
    public class ConfirmEmailRequest
    {
        public string Token { get; set; }
        public string Email { get; set; }
    }
}
