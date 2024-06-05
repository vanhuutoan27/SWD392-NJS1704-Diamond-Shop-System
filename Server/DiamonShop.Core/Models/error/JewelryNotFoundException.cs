namespace DiamonShop.Core.Models.error
{
    public class JewelryNotFoundException : NotFoundException
    {
        public JewelryNotFoundException(Guid Id) : base($"The company with id: {Id} doesn't exist in the database.")
        {

        }
    }
}
