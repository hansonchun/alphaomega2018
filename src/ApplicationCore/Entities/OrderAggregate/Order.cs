using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        #region  Constructor

        public Order()
        {
        }

        public Order(int buyerId, string orderNumber, List<OrderItem> orderItems)
        {
            BuyerId = buyerId;
            OrderNumber = orderNumber;
            OrderItems = orderItems;
        }

        #endregion

        public int BuyerId { get; set; }

        public string OrderNumber { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }

}
