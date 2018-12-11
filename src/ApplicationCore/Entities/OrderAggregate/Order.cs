using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    [Table("orders")]
    public class Order : BaseEntity
    {
        public int BuyerId { get; set; }

        public string OrderNumber { get; set; }

        public int? Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
