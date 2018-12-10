using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaOmega.Web.Models.Quotation
{
    public class QuotationViewModel
    {
        public int? BuyerId { get; set; }

        public string FullName { get; set; }

        public string ContactEmail { get; set; }

        public string PhoneNumber { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string Supplier { get; set; }

        public IList<OrderItemViewModel> OrderItems { get; set; }

        public string Message { get; set; }
    }
}
