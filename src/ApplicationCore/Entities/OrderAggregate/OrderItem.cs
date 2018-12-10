using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; set; }

        public string PartNumber { get; set; }

        public int Quantity { get; set; }
    }
}
