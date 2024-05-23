namespace DiamonShop.Core.Models.auth
{
    public class RegisterRequest
    {
        public string FullName { get; set; }
        //[Required(ErrorMessage = "Email is required")]
        //[EmailAddress]
        public string Email { get; set; }

        //[Required(ErrorMessage = "UserName is required")]

        //[Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
