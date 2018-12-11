using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.OrderAggregate
{
    public class Buyer : BaseEntity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string Message { get; set; }

        public List<Order> Orders { get; set; }
    }
}
