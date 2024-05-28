using DiamonShop.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
