namespace DiamonShop.Core.Models.content.RequestModels
{
    public class CreateUserRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
