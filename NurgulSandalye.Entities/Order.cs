using System;
using System.Collections.Generic;
using System.Text;

namespace NurgulSandalye.Entities
{
    public class Order : BaseEntity
    {
        public string BuyerId { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        public ICollection<OrderItem> OrderItems { get; set; }

        public int AdressId { get; set; }
        public Adress ShippingAdress { get; set; }
        public string PaymentTransactionId { get; set; } //for Iyzico

        //if the user buys on behalf of someone else
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public EnumOrderState OrderState { get; set; } 
    }


    public enum EnumOrderState
    {
        Waiting = 0,
        InCargo = 1,
        Completed = 2,
        Cancelled = 3
    }
}
