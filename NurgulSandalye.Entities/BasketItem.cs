using System;
using System.Collections.Generic;
using System.Text;

namespace NurgulSandalye.Entities
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int BasketId { get; set; }
    }
}
