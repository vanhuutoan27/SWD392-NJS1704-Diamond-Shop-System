using DiamonShop.Core.Shared.Enum;
using System.Text.Json.Serialization;

namespace DiamonShop.Core.Models.content.Respone
{
    public class JewelryResponse
    {
        public Guid JewelryId { get; set; }

        public string SkuID { get; set; }

        public string JewelryName { get; set; }
        public string ProductType { get; set; }

        public string jewelryCategory { get; set; }
        public string MainStoneSize { get; set; }

        public string sideStoneType { get; set; }

        public int sideStoneQuantity { get; set; }

        public double StoneWeight { get; set; }

        public string GoldType { get; set; }

        public string GoldKarat { get; set; }
        public double GoldWeight { get; set; }
        public double Price { get; set; }

        public List<string> Images { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EnumStatus.Status Status { get; set; }


    }
}
