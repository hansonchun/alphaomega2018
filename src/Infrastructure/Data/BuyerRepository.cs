using AlphaOmega.ApplicationCore.Entities.BuyerAggregate;
using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using AlphaOmega.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.Infrastructure.Data
{
    public class BuyerRepository : Repository<Buyer>, IBuyerRepository
    {
        public BuyerRepository(OrderContext orderContext) : base(orderContext)
        {
        }
    }
}
