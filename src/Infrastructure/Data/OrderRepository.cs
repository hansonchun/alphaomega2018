using AlphaOmega.ApplicationCore.Interfaces;
using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.Infrastructure.Data
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext orderContext) : base(orderContext)
        {
        }
    }
}
