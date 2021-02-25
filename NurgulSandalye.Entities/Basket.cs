using System;
using System.Collections.Generic;
using System.Text;

namespace NurgulSandalye.Entities
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }

        public ICollection<BasketItem> Items { get; set; }
    }
}
