using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        public string PurchasePrice { get; set; }

        //public Order(string buyerId, string shipToAddress, List<OrderItem> items)
        //{
        //    BuyerId = buyerId;
        //    ShipToAddress = shipToAddress;
        //}

        //public string BuyerId { get; set; }

        //public DateTime CreationDate { get; set; } = DateTime.Now;

        //public int OrderNumber { get; set; }

        //public string ShipToAddress { get; set; }

    }
}
