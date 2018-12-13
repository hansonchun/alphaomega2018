using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        Pending = 0,
        PaymentRecieved = 1,
        OrderShipped = 2,
        OrderComplete = 3
    }
}
