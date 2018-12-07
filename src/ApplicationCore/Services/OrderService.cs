using AlphaOmega.ApplicationCore.Entities.Order;
using AlphaOmega.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlphaOmega.ApplicationCore.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateOrderAsync(string buyerId, Address shippingAddress, List<OrderItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
