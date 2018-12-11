using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlphaOmega.Web.Models;
using AlphaOmega.Web.Models.Quotation;
using AlphaOmega.ApplicationCore.Interfaces;
using AlphaOmega.ApplicationCore.Entities.OrderAggregate;

namespace AlphaOmega.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOrderService _orderService;
        private readonly IBuyerRepository _buyerRepository;

        public HomeController(IOrderService orderService, IBuyerRepository buyerRepository)
        {
            _orderService = orderService;
            _buyerRepository = buyerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void RequestQuote(QuotationViewModel quotation)
        {
            // TODO - move all this code to the service
            Buyer buyer = new Buyer();
            if (quotation.BuyerId != null)
            {
                // retrieve existing buyer
            }
            else
            {
                // create a new buyer and add it to the db
                buyer = _buyerRepository.Add(CreateBuyer(quotation));
            }

            Order order = new Order
            {
                BuyerId = buyer.Id,
                OrderNumber = DateTime.Now.ToString(),
                OrderItems = quotation.OrderItems.Select(
                    o => new OrderItem { PartNumber = o.PartNumber, Quantity = o.Quantity })
                    .ToList()
            };

            _orderService.CreateOrder(order);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Private methods

        private Buyer CreateBuyer(QuotationViewModel quotation)
        {
            return new Buyer
            {
                FullName = quotation.FullName,
                Email = quotation.ContactEmail,
                PhoneNumber = quotation.PhoneNumber,
                Address = quotation.StreetAddress,
                City = quotation.City,
                Country = quotation.Country,
                State = quotation.State,
                ZipCode = quotation.ZipCode,
                Message = quotation.Message
            };

        }

        #endregion
    }
}
