using AlphaOmega.ApplicationCore.Interfaces;
using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AlphaOmega.Infrastructure.Data
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly OrderContext _orderContext;

        public OrderRepository(OrderContext orderContext) : base(orderContext)
        {
            _orderContext = orderContext;
        }

        public IEnumerable<Order> ListWithOrderItems()
        {
            return _orderContext.Orders.Include(o => o.OrderItems).AsEnumerable();
        }
    }
}
