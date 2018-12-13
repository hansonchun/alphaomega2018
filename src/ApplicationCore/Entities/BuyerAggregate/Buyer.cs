using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Entities.BuyerAggregate
{
    public class Buyer : BaseEntity
    {

        public Buyer(string fullName, string email, string phoneNumber)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Buyer()
        {
        }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Address ShippingAddress { get; set; }

        public Address BillingAddress { get; set; }

        public string Message { get; set; }

        public List<Order> Orders { get; set; }
    }
}
