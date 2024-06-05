﻿namespace DiamonShop.Core.Models.content.Respone
{
    public class JewelryResponse
    {
        public Guid JewelryId { get; set; }

        public string SkuID { get; set; }

        public string Name { get; set; }

        public string ProductType { get; set; }
        public string MainStoneSize { get; set; }

        public string sideStoneType { get; set; }

        public int sideStoneQuantity { get; set; }

        public double StoneWeight { get; set; }

        public string GoldType { get; set; }

        public string GoldKarat { get; set; }
        public double GoldWeight { get; set; }
        public double Price { get; set; }



    }
}