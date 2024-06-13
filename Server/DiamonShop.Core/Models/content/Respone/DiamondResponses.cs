using DiamonShop.Core.Shared.Enum;
using System.Text.Json.Serialization;

namespace DiamonShop.Core.Models.content.Respone
{
    public class DiamondResponses
    {
        public Guid DiamondId { get; set; }
        public string SkuID { get; set; }
        public string Shape { get; set; }
        public string ProductType { get; set; }
        public double Weight { get; set; }
        public string ColorLevel { get; set; }

        public string Clarity { get; set; }
        public string Certification { get; set; }
        public double Size { get; set; }
        public string Fluorescence { get; set; }
        public string QualityOfCut { get; set; }
        public string? Images { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EnumStatus.Status Status { get; set; }

    }
}
