using AlphaOmega.ApplicationCore.Entities.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlphaOmega.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(string buyerId, Address shippingAddress, List<OrderItem> items);
    }
}
