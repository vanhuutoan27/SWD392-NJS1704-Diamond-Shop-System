namespace DiamonShop.Core.Models.content.RequestModels
{
    public class CreateDiamondRequest
    {
        public string Shape { get; set; }

        public double Weight { get; set; }

        public string ColorLevel { get; set; }

        public string Clarity { get; set; }

        public string Certification { get; set; }

        public double Size { get; set; }

        public string Fluorescence { get; set; }

        public string QualityOfCut { get; set; }

        public double Price { get; set; }

        public string? image { get; set; }

    }
}
