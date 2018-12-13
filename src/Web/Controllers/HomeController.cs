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
using AlphaOmega.ApplicationCore.Entities.BuyerAggregate;

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

        /// <summary>
        /// Request new Quotation
        /// </summary>
        /// <param name="model"></param>
        public void RequestQuote(QuotationViewModel model)
        {
            Buyer buyer = new Buyer();
            if (model.BuyerId != null)
            {
                // retrieve existing buyer
                buyer = _buyerRepository.GetById(model.BuyerId.Value);
            }
            else
            {
                // create a new buyer and add it to the db
                buyer = _buyerRepository.Add(new Buyer(model.FullName, model.ContactEmail, model.PhoneNumber)
                {
                    ShippingAddress = new Address(model.StreetAddress, model.City, model.State, model.Country, model.ZipCode),
                    BillingAddress = new Address(model.StreetAddress, model.City, model.State, model.Country, model.ZipCode)
                });
            }

            List<OrderItem> orderItems = model.OrderItems
                .Select(o => new OrderItem { PartNumber = o.PartNumber, Quantity = o.Quantity }).ToList(); 

            _orderService.CreateOrder(buyer.Id, orderItems);
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

    }
}
