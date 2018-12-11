﻿using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlphaOmega.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);
    }
}
