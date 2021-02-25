using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurgulSandalye.WebUI.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<PictureUri> PictureUris { get; set; }

        public decimal Price { get; set; }

        public bool Discount { get; set; }
        public decimal? DiscountedPrice { get; set; }

        public Material Material { get; set; }
    }
}
