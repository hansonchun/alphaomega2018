using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaOmega.ApplicationCore.Interfaces;
using AlphaOmega.Infrastructure.Data;
using AlphaOmega.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlphaOmega.Web.Controllers.Order
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            var orders = _orderRepository.ListAll();

            var viewModel = orders
                .Select(o => new OrderViewModel()
                {
                    OrderNumber = o.OrderNumber
                });

            return View(viewModel);
        }
    }
}