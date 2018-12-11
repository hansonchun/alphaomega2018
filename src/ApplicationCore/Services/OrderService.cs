using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using AlphaOmega.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlphaOmega.ApplicationCore.Services
{
    public class OrderService : IOrderService
    {

        private readonly IRepository <Order>_orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order CreateOrder(Order order)
        {
            return _orderRepository.Add(order);
        }
    }
}
