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

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void RequestQuote(QuotationViewModel quotation)
        {
            Order order = new Order();
            Buyer buyer = new Buyer();
            List<OrderItem> orderItems = new List<OrderItem>();

            if(quotation.BuyerId != null)
            {
                // retrieve buyer
            }
            else
            {
                buyer.FullName = quotation.FullName;
                buyer.Email = quotation.ContactEmail;
                buyer.PhoneNumber = quotation.PhoneNumber;
                buyer.City = quotation.City;
                buyer.State = quotation.State;
                buyer.Country = quotation.Country;
                buyer.ZipCode = quotation.ZipCode;
                buyer.Message = quotation.Message;
            }

            orderItems = quotation.OrderItems.Select(
                o => new OrderItem { PartNumber = o.PartNumber, Quantity = o.Quantity })
                .ToList();

            _orderService.CreateOrder(order, buyer, orderItems);
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
