using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    [Table("orderitems")]
    public class OrderItem : BaseEntity
    {
        public int? ProductId { get; set; }
        public string PartNumber { get; set; }
        public int? Quantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
