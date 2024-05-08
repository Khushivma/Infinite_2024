using Microsoft.AspNetCore.Mvc;
using EkartApp.Repositary;
using EkartApp.Models;
using System;
using System.Linq;

namespace EkartApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: /Order/Place
        public IActionResult Place()
        {
            // Implement logic to display view for placing an order
            return View();
        }

        // POST: /Order/Place
        [HttpPost]
        public IActionResult Place(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.PlaceOrder(order);
                return RedirectToAction(nameof(OrderDetails), new { orderId = order.OrderId });
            }
            return View(order);
        }

        // GET: /Order/OrderDetails/{orderId}
        public IActionResult OrderDetails(int orderId)
        {
            var order = _orderRepository.GetOrderDetails(orderId);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: /Order/Bill/{orderId}
        public IActionResult Bill(int orderId)
        {
            var bill = _orderRepository.GetBill(orderId);
            if (bill == null || !bill.Any())
            {
                return NotFound();
            }
            return View(bill);
        }

        // GET: /Order/CustomerByOrderDate/{orderDate}
        public IActionResult CustomerByOrderDate(DateTime orderDate)
        {
            var customers = _orderRepository.GetCustomersByOrderDate(orderDate);
            if (customers == null || !customers.Any())
            {
                return NotFound();
            }
            return View(customers);
        }

        // GET: /Order/HighestOrderCustomer
        public IActionResult HighestOrderCustomer()
        {
            var highestOrderCustomer = _orderRepository.GetCustomerWithHighestOrder();
            if (highestOrderCustomer == null)
            {
                return NotFound();
            }
            return View(highestOrderCustomer);
        }
    }
}

